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
    public class Test_ArchivoTexto
    {
        [TestMethod]
        public void Test_Escribir_Valido()
        {
            //ARRANGE
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PruebaTest.txt");
            ArchivoTexto archivo = new ArchivoTexto();


            //ACT
            archivo.Escribir("Pruebaxd", path);

            //ASSERT
            Assert.IsTrue(File.Exists(path));
        }

        [TestMethod]
        public void Test_Leer_Valido()
        {
            //ARRANGE
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"PruebaTest.txt");
            string respuesta;
            ArchivoTexto archivo = new ArchivoTexto();


            //ACT
            respuesta = archivo.Leer(path);
            //ASSERT
            Assert.AreEqual("Pruebaxd\n", respuesta);
        }
    }
}
