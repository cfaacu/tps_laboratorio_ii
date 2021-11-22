using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestTpFinal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcularEdadMayorA_Valido()
        {
            //ARRANGE
            int mayor = 40;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>()
            {
                new Empleado("Pepe", "Alonzo", 65, ESexo.Hombre, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true),
                new Empleado("Rodolfo", "Benitez", 45, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.RRHH, 18000, true),
                new Empleado("Facundo", "Careri", 22, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.CM, 25000, true),
            };
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularEdadMayorA(mayor);

            //ASSERT
            Assert.IsTrue(listRetorno.Count == 2);
            Assert.IsTrue(listRetorno[0].Edad >= 40);
            Assert.IsTrue(listRetorno[1].Edad >= 40);
        }

        [ExpectedException(typeof(ListVaciaException))]
        [TestMethod]
        public void TestCalcularEdadMayorA_Invalido()
        {
            //ARRANGE
            int mayor = 80;
            Datos.listaEmpleados.Clear();

            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularEdadMayorA(mayor);

            //ASSERT
            Assert.IsTrue(listRetorno.Count == 0);
        }

        [TestMethod]
        public void TestCalcularSexo_Valido()
        {
            //ARRANGE
            ESexo sexo = ESexo.Hombre;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>()
            {
                new Empleado("Pepe", "Alonzo", 65, ESexo.Otros, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true),
                new Empleado("Rodolfo", "Benitez", 45, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.RRHH, 18000, true),
                new Empleado("Facundo", "Careri", 22, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.CM, 25000, true),
            };
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();
            //ACT
            listRetorno = Datos.CalcularSexo(sexo);

            //ASSERT
            Assert.IsTrue(listRetorno.Count == 2);
            Assert.IsTrue(listRetorno[0].Sexo == ESexo.Hombre);
            Assert.IsTrue(listRetorno[1].Sexo == ESexo.Hombre);
        }
        
        [TestMethod]
        public void TestCalcularSexo_Invalido()
        {
            //ARRANGE
            ESexo sexo = ESexo.Mujer;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>()
            {
                new Empleado("Pepe", "Alonzo", 65, ESexo.Otros, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true),
                new Empleado("Rodolfo", "Benitez", 45, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.RRHH, 18000, true),
                new Empleado("Facundo", "Careri", 22, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.CM, 25000, true),
            };
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();
            //ACT
            listRetorno = Datos.CalcularSexo(sexo);

            //ASSERT
            Assert.IsTrue(listRetorno.Count == 0);
        }

        [TestMethod]
        public void TestCalcularNacionalidad_Valido()
        {
            //ARRANGE
            ENacionalidad nacionalidad = ENacionalidad.Chile;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>()
            {
                new Empleado("Pepe", "Alonzo", 65, ESexo.Otros, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true),
                new Empleado("Rodolfo", "Benitez", 45, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.RRHH, 18000, true),
                new Empleado("Facundo", "Careri", 22, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.CM, 25000, true),
            };
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularNacionalidad(nacionalidad);

            //ASSERT
            Assert.IsTrue(listRetorno.Count == 1);
            Assert.IsTrue(listRetorno[0].Nacionalidad == nacionalidad);
        }

        [ExpectedException(typeof(ListVaciaException))]
        [TestMethod]
        public void TestCalcularNacionalidad_Invalido()
        {
            //ARRANGE
            ENacionalidad nacionalidad = ENacionalidad.Chile;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>();
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularNacionalidad(nacionalidad);

            //ASSERT
            Assert.IsFalse(listRetorno.Count == 1);
        }

        [TestMethod]
        public void TestCalcularEstadoCivil_Valido()
        {
            //ARRANGE
            EEstadoCivil estadoCivil = EEstadoCivil.Casado;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>()
            {
                new Empleado("Pepe", "Alonzo", 65, ESexo.Otros, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true),
                new Empleado("Rodolfo", "Benitez", 45, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.RRHH, 18000, true),
                new Empleado("Facundo", "Careri", 22, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.CM, 25000, true),
            };
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularEstadoCivil(estadoCivil);

            //ASSERT
            Assert.IsTrue(listRetorno.Count == 1);
            Assert.IsTrue(listRetorno[0].EstadoCivil == estadoCivil);
        }

        [ExpectedException(typeof(ListVaciaException))]
        [TestMethod]
        public void TestCalcularEstadoCivil_Invalido()
        {
            //ARRANGE
            EEstadoCivil estadoCivil = EEstadoCivil.Soltero;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>();
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularEstadoCivil(estadoCivil);

            //ASSERT
        }

        [TestMethod]
        public void TestCalcularPuesto_Valido()
        {
            //ARRANGE
            EPuesto puesto = EPuesto.Atencion;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>()
            {
                new Empleado("Pepe", "Alonzo", 65, ESexo.Otros, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true),
                new Empleado("Rodolfo", "Benitez", 45, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.RRHH, 18000, true),
                new Empleado("Facundo", "Careri", 22, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.CM, 25000, true),
            };
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularPuesto(puesto);

            //ASSERT
            Assert.IsTrue(listRetorno.Count == 1);
            Assert.IsTrue(listRetorno[0].Puesto == puesto);
        }

        [ExpectedException(typeof(ListVaciaException))]
        [TestMethod]
        public void TestCalcularPuesto_Invalido()
        {
            //ARRANGE
            EPuesto puesto = EPuesto.Atencion;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>();
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularPuesto(puesto);

            //ASSERT
        }

        [TestMethod]
        public void TestCalcularSueldoMayorA_Valido()
        {
            //ARRANGE
            double sueldo = 10000;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>()
            {
                new Empleado("Pepe", "Alonzo", 65, ESexo.Otros, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true),
                new Empleado("Rodolfo", "Benitez", 45, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.RRHH, 18000, true),
                new Empleado("Facundo", "Careri", 22, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.CM, 25000, true),
            };
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularSueldoMayorA(sueldo);

            //ASSERT
            Assert.IsTrue(listRetorno.Count == 3);
            Assert.IsTrue(listRetorno[0].Sueldo > sueldo);
            Assert.IsTrue(listRetorno[1].Sueldo > sueldo);
            Assert.IsTrue(listRetorno[2].Sueldo > sueldo);
        }

        [ExpectedException(typeof(ListVaciaException))]
        [TestMethod]
        public void TestCalcularSueldoMayorA_Invalido()
        {
            //ARRANGE
            double sueldo = 10000;
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>();
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularSueldoMayorA(sueldo);

            //ASSERT
        }

        [TestMethod]
        public void TestCalcularPuestosActivos_Valido()
        {
            //ARRANGE
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>()
            {
                new Empleado("Pepe", "Alonzo", 65, ESexo.Otros, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true),
                new Empleado("Rodolfo", "Benitez", 45, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.RRHH, 18000, true),
                new Empleado("Facundo", "Careri", 22, ESexo.Hombre, ENacionalidad.Argentina, EEstadoCivil.Soltero, EPuesto.CM, 25000, true),
            };
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularPuestosActivos();

            //ASSERT
            Assert.IsTrue(listRetorno.Count == 3);
            Assert.IsTrue(listRetorno[0].Activo == true);
            Assert.IsTrue(listRetorno[1].Activo == true);
            Assert.IsTrue(listRetorno[2].Activo == true);
        }

        [ExpectedException(typeof(ListVaciaException))]
        [TestMethod]
        public void TestCalcularPuestosActivos_Invalido()
        {
            //ARRANGE
            Datos.listaEmpleados.Clear();
            List<Empleado> listAux = new List<Empleado>();
            Datos.listaEmpleados.AddRange(listAux);
            List<Empleado> listRetorno = new List<Empleado>();

            //ACT
            listRetorno = Datos.CalcularPuestosActivos();

            //ASSERT
        }
    }
}
