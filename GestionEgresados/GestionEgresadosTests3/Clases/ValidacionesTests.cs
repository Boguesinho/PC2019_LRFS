using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionEgresados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEgresados.Tests
{
    [TestClass()]
    public class ValidacionesTests
    {

        [TestMethod()]
        public void validarNombreTest()
        {
            Validaciones validaciones = new Validaciones();
            Assert.AreEqual(validaciones.validarNombre("Arturo"), Validaciones.ResultadosValidacion.NombreValido);
        }

        [TestMethod()]
        public void validarApellidosTest()
        {
            Validaciones validaciones = new Validaciones();
            Assert.AreEqual(validaciones.validarApellidos("Galindo"), Validaciones.ResultadosValidacion.ApellidosValidos);
        }

        [TestMethod()]
        public void validarCorreoTest()
        {
            Validaciones validaciones = new Validaciones();
            Assert.AreEqual(validaciones.validarCorreo("arturo98@gmail.com"), Validaciones.ResultadosValidacion.CorreoValido);
        }

        [TestMethod()]
        public void validarTelefonoTest()
        {
            Validaciones validaciones = new Validaciones();
            Assert.AreEqual(validaciones.validarTelefono("2281108314"), Validaciones.ResultadosValidacion.TelefonoValido);
        }
    }
}