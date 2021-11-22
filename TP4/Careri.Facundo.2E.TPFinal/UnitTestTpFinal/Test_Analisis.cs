using Entidades.Clases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTpFinal
{
    [TestClass]
    public class Test_Analisis
    {
        [TestMethod]
        public void Test_CalcularPorcentaje_Valido()
        {
            //ARRANGE
            float cantidadFiltrada = 10;
            float cantidadTotal = 20;
            float resultado;
            Analisis.IndicarMayorA25 += Vacio;
            //ACT
            resultado = Analisis.CalcularPorcentaje(cantidadFiltrada, cantidadTotal);

            //ASSERT
            Assert.IsTrue(50 == resultado);
        }
        public static void Vacio()
        {
        }
    }
}
