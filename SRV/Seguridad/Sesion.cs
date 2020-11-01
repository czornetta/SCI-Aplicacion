using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.MuiltiIdioma;
using Entidades.Seguridad;
using Servicios.MultiIdioma;

namespace Servicios.Seguridad
{
    public class Sesion: IIdioma
    {
        private Usuario _usuario;
        private List<Privilegio> _privilegios;
        private static Sesion _instancia;

        private Idioma _idioma;
        
        private List<IIdiomaObservador> _idiomaObservadores = new List<IIdiomaObservador>();

        private Sesion()
        {

        }

        #region Gestión de Sesion
        public static Sesion Instancia 
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Sesion();
                }

                return _instancia;
            }
        }

        public static void IniciarSesion(Usuario usuario)
        {
            Instancia._usuario = usuario;
        }

        public static void CerrarSesion()
        {
            Instancia._usuario = null;
        }     

        public static bool SesionActiva()
        {
            return Instancia._usuario != null;
        }

        public Usuario Usuario
        {
            get
            {
                return Instancia._usuario;
            }
        }
        #endregion

        #region Gestión de Privilegios
        public List<Privilegio> Privilegios
        {
            set
            {
                _privilegios = value;
            }

            get => _privilegios;
            
        }

        public bool TieneLlave(Llave llave)
        {
            bool res = false;
            foreach (var item in Instancia._privilegios)
            {
                if (item.Llave== Llave.NoDefinida)
                {
                    res = TieneLlave(item, llave);
                    if (res) 
                        break;
                }
                else if (item.Llave.Equals(llave))
                {
                    res = true;
                    break;
                }
            }

            return res;
        }

        public bool TieneLlave(Privilegio rol, Llave llave)
        {
            bool res = false;

            foreach (var item in rol.Privilegios)
            {
                if (item.Llave == Llave.NoDefinida)
                {
                    res = TieneLlave(item, llave);
                    if (res)
                        break;
                }
                else if (item.Llave.Equals(llave))
                {
                    res = true;
                    break;
                }
            }

            return res;
        }
        #endregion

        #region Gestión de Idiomas
        public void SuscribirObservador(IIdiomaObservador obs)
        {
            _idiomaObservadores.Add(obs);
        }

        public void DesuscribirObservador(IIdiomaObservador obs)
        {
            _idiomaObservadores.Remove(obs);
        }

        public void Notificar(Idioma idm)
        {
            foreach (var o in _idiomaObservadores)
            {
                o.ActualizarIdioma(idm);
            }
        }

        public Idioma Idioma
        {
            set
            {
                _idioma = value;
                Notificar(value);
            }

            get => _idioma;

        }

        //public Dictionary<string, string> Diccionario
        //{
        //    set
        //    {
        //        _diccionario = value;
        //    }

        //    get => _diccionario;

        //}
        #endregion
    }
}

