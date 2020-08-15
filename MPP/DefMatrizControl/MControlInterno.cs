using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades.DefMatrizControl;
using System.Collections;
using System.Data;
using Mapeo.Seguridad;

namespace Mapeo.DefMatrizControl
{
    public class MControlInterno
    {
        private string[] Sql = { "addControlInterno", "updControlInterno", "delControlInterno", "getControlesInternos" };

        public void Operacion(ControlInternoPropuesto obj, int ope)
        {

            Hashtable param = new Hashtable();
            var lEstado = (new MEstadoControlInterno()).Leer();

            try
            {
                switch (ope)
                {
                    case 0:
                        param.Add("@nombre", obj.Nombre);
                        param.Add("@descripcion", obj.Descripcion);
                        param.Add("@idtipocontrol", obj.Tipo.Id);
                        param.Add("@idperiodicidad", obj.Periodicidad.Id);
                        param.Add("@idriesgo", obj.Riesgo.Id);
                        param.Add("@idestado", lEstado.FirstOrDefault(x => x.Clase == obj.GetType().ToString()).Id);
                        param.Add("@observacion", DBNull.Value);
                        param.Add("@comentario", DBNull.Value);
                        break;

                    case 1:
                        param.Add("@idcontrolinterno", obj.Id);
                        param.Add("@nombre", obj.Nombre);
                        param.Add("@descripcion", obj.Descripcion);
                        param.Add("@idtipocontrol", obj.Tipo.Id);
                        param.Add("@idperiodicidad", obj.Periodicidad.Id);
                        param.Add("@idriesgo", DBNull.Value);
                        param.Add("@idestado", DBNull.Value);
                        
                        if (obj.Observacion == null)
                        {
                            param.Add("@observacion", DBNull.Value);
                        }
                        else
                        {
                            param.Add("@observacion", obj.Observacion);
                        }

                        if (obj.Comentario == null)
                        {
                            param.Add("@comentario", DBNull.Value);
                        }
                        else
                        {
                            param.Add("@comentario", obj.Comentario);
                        }
                        break;
                    case 2:
                        param.Add("@idcontrolinterno", obj.Id);
                        break;
                    default:
                        break;
                }

                (new Acceso()).Escribir(Sql[ope], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public void SetEstadoControlInterno(ControlInterno obj, EstadoControlInterno estado)
        {

            Hashtable param = new Hashtable();

            try
            {
                param.Add("@idcontrolinterno", obj.Id);
                param.Add("@nombre", obj.Nombre);
                param.Add("@descripcion", obj.Descripcion);
                param.Add("@idtipocontrol", obj.Tipo.Id);
                param.Add("@idperiodicidad", obj.Periodicidad.Id);
                param.Add("@idriesgo", DBNull.Value);
                param.Add("@idestado", estado.Id);


                if (obj.Observacion == null)
                {
                    param.Add("@observacion", DBNull.Value);
                }
                else
                {
                    param.Add("@observacion", obj.Observacion);
                }

                if (obj.Comentario == null)
                {
                    param.Add("@comentario", DBNull.Value);
                }
                else
                {
                    param.Add("@comentario", obj.Comentario);
                }



                (new Acceso()).Escribir(Sql[1], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public IList Leer(Riesgo riesgo,EstadoControlInterno estado)
        {
            
            Hashtable param = new Hashtable();

            try
            {
                var lTipoControl = (new MTipoControl()).Leer();
                var lPeriodicidad = (new MPeriodicidadControl()).Leer();
                
                if (riesgo != null)
                    param.Add("@idriesgo", riesgo.Id);
                else
                    param.Add("@idriesgo", DBNull.Value);

                var res = (from reg in ((new Acceso()).Leer(Sql[3], param)).Tables[0].AsEnumerable()
                       where reg.Field<int>("idestadocontrolinterno") == estado.Id
                       select new
                       {
                           Id = reg.Field<int>("idcontrolinterno"),
                           Nombre = reg.Field<string>("nombre"),
                           Descripcion = reg.Field<string>("descripcion"),
                           Tipo = lTipoControl.FirstOrDefault(x => x.Id == reg.Field<int>("idtipocontrol")),
                           Periodicidad = lPeriodicidad.FirstOrDefault(x => x.Id == reg.Field<int>("idperiodicidad")),
                           Riesgo = riesgo,
                           Observacion = reg.Field<string>("observacion"),
                           Comentario = reg.Field<string>("comentario")
                       }).ToList();

                return res;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
