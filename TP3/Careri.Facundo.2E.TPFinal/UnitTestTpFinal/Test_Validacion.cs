using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTpFinal
{
    [TestClass]
    public class Test_Validacion
    {
        [TestMethod]
        public void TestValidarSoloLetras_Valido()
        {
            //ARRANGE
            string nombre = "Pepe";
            bool respuesta;

            //ACT
            respuesta = Validacion.ValidarSoloLetras(nombre);
            //ASSERT
            Assert.IsTrue(respuesta);
        }
        [TestMethod]
        public void TestValidarSoloLetras_Empty()
        {
            //ARRANGE
            string nombre = string.Empty;
            bool respuesta;

            //ACT
            respuesta = Validacion.ValidarSoloLetras(nombre);
            //ASSERT
            Assert.IsFalse(respuesta);
        }
        [TestMethod]
        public void TestValidarSoloLetras_Invalido()
        {
            //ARRANGE
            string nombre = "123 45678 sdafge";
            bool respuesta;

            //ACT
            respuesta = Validacion.ValidarSoloLetras(nombre);
            //ASSERT
            Assert.IsFalse(respuesta);
        }

        [TestMethod]
        public void TestValidarCampos_Valido()
        {
            //ARRANGE
            string nombre = "Robert";
            string apellido = "Contenr";
            int edad = 25;
            ESexo sexo = ESexo.Otros;
            ENacionalidad nacionalidad = ENacionalidad.EEUU;
            EEstadoCivil estadoCivil = EEstadoCivil.Casado;
            EPuesto puesto = EPuesto.RRHH;
            double sueldo = 18600;
            bool activo = true;
            bool respuesta;

            //ACT
            respuesta = Validacion.ValidarCampos(nombre,apellido,edad,sexo,nacionalidad,estadoCivil,puesto,sueldo,activo);
            //ASSERT
            Assert.IsTrue(respuesta);
        }
        [TestMethod]
        [ExpectedException(typeof(DatosInvalidosException))]
        public void TestValidarCampos_Invalido()
        {
            //ARRANGE
            string nombre = "";
            string apellido = "486fgd5";
            int edad = 2500;
            ESexo sexo = ESexo.Otros;
            ENacionalidad nacionalidad = ENacionalidad.EEUU;
            EEstadoCivil estadoCivil = EEstadoCivil.Casado;
            EPuesto puesto = EPuesto.RRHH;
            double sueldo = 18600;
            bool activo = true;
            bool respuesta;

            //ACT
            respuesta = Validacion.ValidarCampos(nombre, apellido, edad, sexo, nacionalidad, estadoCivil, puesto, sueldo, activo);
            //ASSERT
            Assert.IsTrue(respuesta);
        }
    }
}
