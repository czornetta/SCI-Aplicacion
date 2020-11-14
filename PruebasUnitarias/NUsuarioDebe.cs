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
        [InlineData("adm", "123", LoginResult.ValidUser)]
        public void IniciarSesion(string nombre, string clave, LoginResult rEsperado)
        {
            // Arrange
            NUsuario nUsuario = new NUsuario();

            // Act
            LoginResult resultado = nUsuario.IniciarSesion(nombre, clave);

            // Assert
            Assert.Equal(rEsperado, resultado);

        }

    }
}
