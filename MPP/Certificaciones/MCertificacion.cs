using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades.Certificaciones;
using System.Collections;
using System.Data;
using Entidades.Seguridad;
using Entidades.DefMatrizControl;
using Mapeo.Seguridad;

namespace Mapeo.Certificaciones
{
    public class MCertificacion
    {
        private string[] Sql = { "addCertificacion", "updCertificacion", "delCertificacion", "getCertificaciones" };

        public void Operacion(Certificacion obj, int ope)
        {

            Hashtable param = new Hashtable();
         
            try
            {
                switch (ope)
                {
                    case 0:
                        param.Add("@fecha", obj.Fecha);
                        param.Add("@idcontrolinterno", obj.ControlInterno.Id);
                        param.Add("@idusuario", obj.Usuario.IdUsuario);
                        param.Add("@idresultado", obj.Resultado.Id);
                        break;

                    case 1:
                        param.Add("@idcertificacion", obj.Id);
                        param.Add("@idresultado", obj.Resultado.Id);
                        break;
                    //case 2:
                    //    param.Add("@idcontrolinterno", obj.Id);
                    //    break;
                    default:
                        break;
                }

                //if (obj.Incidente.Id > 0)
                //{
                //    param.Add("@idincidente", obj.Incidente.Id);                    
                //}

                if (obj.Incidente.Descripcion != null)
                {
                    param.Add("@descincidente", obj.Incidente.Descripcion);
                    param.Add("@fechaincidente", obj.Incidente.Fecha);
                }
                else
                {
                    param.Add("@descincidente", DBNull.Value);
                    param.Add("@fechaincidente", DBNull.Value);
                }

                if (obj.Excepcion.Id > 0)
                {
                    param.Add("@idexcepcion", obj.Excepcion.Id);
                }

                if (obj.Excepcion.Descripcion != null)
                {
                    param.Add("@descexcepcion", obj.Excepcion.Descripcion);
                    param.Add("@idestadoexcepcion", obj.Excepcion.Estado.Id);
                    param.Add("@fechaexcepcion", obj.Excepcion.Fecha);
                }
                else
                {
                    param.Add("@descexcepcion", DBNull.Value);
                    param.Add("@idestadoexcepcion", DBNull.Value);
                    param.Add("@fechaexcepcion", DBNull.Value);
                }

                (new Acceso()).Escribir(Sql[ope], param);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public void UpdateExcepcion(Certificacion obj)
        {

            Hashtable param = new Hashtable();

            try
            {
                param.Add("@idexcepcion", obj.Excepcion.Id);
                param.Add("@idestadoexcepcion", obj.Excepcion.Estado.Id);

                (new Acceso()).Escribir("updExcepcion", param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<Certificacion> GetCertificaciones(ControlInternoAceptado control)
        {
            List<Certificacion> certificaciones = new List<Certificacion>();
            Hashtable param = new Hashtable();

            try
            {
                var lUsuario = (new MUsuario()).Leer();

                if (control != null)
                    param.Add("@idcontrolinterno", control.Id);
                else
                    param.Add("@idcontrolinterno", DBNull.Value);

                var res = (from reg in ((new Acceso()).Leer(Sql[3], param)).Tables[0].AsEnumerable()
                           select new 
                            {   
                               Certificacion = new Certificacion
                                                        {
                                                            Id = reg.Field<int>("idcertificacion"),
                                                            Fecha = reg.Field<DateTime>("fecha"),
                                                            Resultado = new ResultadoCertificacion
                                                            {
                                                                Id = reg.Field<int>("idresultado"),
                                                                Nombre = reg.Field<string>("nombreresultado")
                                                            },
                                                            Usuario = lUsuario.FirstOrDefault(x => x.IdUsuario == reg.Field<int>("idusuario"))
                                                        },
                               Excepcion = new Excepcion
                                                    {
                                                        Id = reg.Field<int>("idexcepcion"),
                                                        Descripcion = reg.Field<string>("descexcepcion"),
                                                        Fecha = reg.Field<DateTime>("fechaexcepcion"),
                                                        Estado = new EstadoExcepcion
                                                        {
                                                            Id = reg.Field<int>("idestadoexcepcion"),
                                                            Nombre = reg.Field<string>("nombreestado")
                                                        }
                                                    },
                               Incidente = new Incidente
                                                   {
                                                       Id = reg.Field<int>("idincidente"),
                                                       Descripcion = reg.Field<string>("descincidente"),
                                                       Fecha = reg.Field<DateTime>("fechaIncidente")
                                                   }
                           }).ToList();

                foreach (var cer in res)
                {
                    cer.Certificacion.ControlInterno = control;

                    if (cer.Excepcion.Id > 0)
                    {
                        cer.Certificacion.Excepcion.Id = cer.Excepcion.Id;
                        cer.Certificacion.Excepcion.Descripcion = cer.Excepcion.Descripcion;
                        cer.Certificacion.Excepcion.Fecha = cer.Excepcion.Fecha;
                        cer.Certificacion.Excepcion.Estado = cer.Excepcion.Estado;
                    }

                    if (cer.Incidente.Id > 0)
                    {
                        cer.Certificacion.Incidente.Id = cer.Incidente.Id;
                        cer.Certificacion.Incidente.Descripcion = cer.Incidente.Descripcion;
                        cer.Certificacion.Incidente.Fecha = cer.Incidente.Fecha;
                    }

                    certificaciones.Add(cer.Certificacion);
                }

                return certificaciones;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
        public List<ResultadoCertificacion> GetResultadosCertificaciones()
        {
            Hashtable param = new Hashtable();

            try
            {
                var res = (from reg in ((new Acceso()).Leer("getResutadoCertificacion", param)).Tables[0].AsEnumerable()
                           select new ResultadoCertificacion
                           {
                                Id = reg.Field<int>("idresultado"),
                                Nombre = reg.Field<string>("nombre")
                               
                           }).ToList<ResultadoCertificacion>();

                return res;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<EstadoExcepcion> GetEstadosExcepcion()
        {
            Hashtable param = new Hashtable();

            try
            {
                var res = (from reg in ((new Acceso()).Leer("getEstadosExcepcion", param)).Tables[0].AsEnumerable()
                           select new EstadoExcepcion
                           {
                               Id = reg.Field<int>("idestado"),
                               Nombre = reg.Field<string>("nombre")

                           }).ToList<EstadoExcepcion>();

                return res;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
