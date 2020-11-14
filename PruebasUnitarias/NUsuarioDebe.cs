using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Servicios.Seguridad;
using Negocio.Seguridad;

namespace PruebasUnitarias
{
    public class NUsuarioDebe
    {
        [Theory]
        [InlineData("admi", "123",LoginResult.InvalidUsername)]
        [InlineData("admin", "1", LoginResult.InvalidPassword)]
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
    }
}
