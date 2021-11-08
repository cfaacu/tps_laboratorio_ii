using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTpFinal
{
    [TestClass]
    public class Test_Serializadora
    {
        [TestMethod]
        public void Test_EscribirJson_Valido()
        {
            //ARRANGE
            Serializadora<Empleado> serJson = new Serializadora<Empleado>(ETipo.JSON);
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PruebaTest.json");
            Empleado emp1 = new Empleado("Pepe", "Alonzo", 65, ESexo.Hombre, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true);

            //ACT
            serJson.Escribir(emp1, path);


            //ASSERT
            Assert.IsTrue(File.Exists(path));
        }
        [TestMethod]
        public void Test_LeerJson_Valido()
        {
            //ARRANGE
            Serializadora<Empleado> serJson = new Serializadora<Empleado>(ETipo.JSON);
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PruebaTest.json");
            Empleado emp1 = new Empleado("Pepe", "Alonzo", 65, ESexo.Hombre, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true);
            Empleado emp2;
            //ACT
            emp2 = serJson.Leer(path);


            //ASSERT
            Assert.IsTrue(File.Exists(path));
            Assert.AreEqual(emp1.Nombre, emp2.Nombre);
            Assert.AreEqual(emp1.Apellido, emp2.Apellido);
            Assert.AreEqual(emp1.Edad, emp2.Edad);
            Assert.AreEqual(emp1.EstadoCivil, emp2.EstadoCivil);
            Assert.AreEqual(emp1.Nacionalidad, emp2.Nacionalidad);
            Assert.AreEqual(emp1.Sueldo, emp2.Sueldo);
            Assert.AreEqual(emp1.Sexo, emp2.Sexo);
            Assert.AreEqual(emp1.Activo, emp2.Activo);
        }

        [TestMethod]
        public void Test_EscribirXml_Valido()
        {
            //ARRANGE
            Serializadora<Empleado> serXml = new Serializadora<Empleado>(ETipo.XML);
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PruebaTest.xml");
            Empleado emp1 = new Empleado("Pepe", "Alonzo", 65, ESexo.Hombre, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true);

            //ACT
            serXml.Escribir(emp1, path);


            //ASSERT
            Assert.IsTrue(File.Exists(path));
        }
        [TestMethod]
        public void Test_LeerXml_Valido()
        {
            //ARRANGE
            Serializadora<Empleado> serXml = new Serializadora<Empleado>(ETipo.XML);
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PruebaTest.xml");
            Empleado emp1 = new Empleado("Pepe", "Alonzo", 65, ESexo.Hombre, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true);
            Empleado emp2;
            //ACT
            emp2 = serXml.Leer(path);


            //ASSERT
            Assert.IsTrue(File.Exists(path));
            Assert.AreEqual(emp1.Nombre, emp2.Nombre);
            Assert.AreEqual(emp1.Apellido, emp2.Apellido);
            Assert.AreEqual(emp1.Edad, emp2.Edad);
            Assert.AreEqual(emp1.EstadoCivil, emp2.EstadoCivil);
            Assert.AreEqual(emp1.Nacionalidad, emp2.Nacionalidad);
            Assert.AreEqual(emp1.Sueldo, emp2.Sueldo);
            Assert.AreEqual(emp1.Sexo, emp2.Sexo);
            Assert.AreEqual(emp1.Activo, emp2.Activo);
        }
    }
}
