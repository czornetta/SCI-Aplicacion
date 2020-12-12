using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Servicios.Seguridad;
using Negocio.Seguridad;
using Entidades.Seguridad;

namespace PruebasUnitarias
{
    public class NUsuarioDebe
    {
        [Theory]
        [InlineData(null, "123", LoginResult.InvalidUsername)]
        [InlineData("admi", "123",LoginResult.InvalidUsername)]
        [InlineData("admin", "1", LoginResult.InvalidPassword)]
        [InlineData("admin", null, LoginResult.InvalidPassword)]
        [InlineData("admin", "123", LoginResult.ValidUser)]
        public void IniciarSesion(string nombre, string clave, LoginResult rEsperado)
        {
            // Arrange
            NUsuario nUsuario = new NUsuario();
            LoginResult resultado;

            // Act
            try
            {
                resultado = nUsuario.IniciarSesion(nombre, clave);
                nUsuario.CerrarSesion();
            }
            catch (LoginException ex)
            {

                resultado = ex.Result;
            }
            
            // Assert
            Assert.Equal(rEsperado, resultado);

        }

        [Theory]
        [InlineData("admin", "123", LoginResult.ExistsActiveSesion)]
        public void InformarExisteSesionActiva(string nombre, string clave, LoginResult rEsperado)
        {
            // Arrange
            NUsuario nUsuario = new NUsuario();
            LoginResult resultado;
            string usr = "jose";
            string psw = "123";

            // Act
            try
            {
                resultado = nUsuario.IniciarSesion(usr, psw);
                resultado = nUsuario.IniciarSesion(nombre, clave);
            }
            catch (LoginException ex)
            {

                resultado = ex.Result;
            }

            // Assert
            Assert.Equal(rEsperado, resultado);

        }

        [Theory]
        [InlineData("admin", "123", false)]
        public void CerrarSesion(string nombre, string clave, bool rEsperado)
        {
            // Arrange
            NUsuario nUsuario = new NUsuario();
            bool resultado;
            
            // Act            
            nUsuario.IniciarSesion(nombre, clave);
            nUsuario.CerrarSesion();

            resultado = Sesion.SesionActiva();
            
            // Assert
            Assert.Equal(rEsperado, resultado);

        }

        [Theory]
        [InlineData(null, "123", 1, true)]
        [InlineData("admin", null, 1, true)]
        [InlineData("admin", "123",0, true)]
        public void InformarAtributoNotNullException(string nombre, string clave, int areaId, bool rEsperado)
        {
            // Arrange
            NUsuario nUsuario = new NUsuario();
            bool resultado = false;
            AreaNegocio areaNegocio;

            // Act
            try
            {
                if (areaId > 0)
                {
                    areaNegocio = new AreaNegocio {Id = areaId };
                }
                else
                {
                    areaNegocio = new AreaNegocio();
                }

                Usuario usr = new Usuario { Nombre = nombre, Clave = clave, AreaNegocio = areaNegocio };
                nUsuario.VerificarDatosObligatorios(usr);
               
            }
            catch (AtributoNotNullException)
            {
                resultado = true;
            }
            
            // Assert
            Assert.Equal(rEsperado, resultado);

        }
    }
}
