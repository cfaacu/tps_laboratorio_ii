using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public delegate void Indicador();
    public static class Analisis
    {
        public static event Indicador IndicarMayorA25;
        public static event Indicador IndicarMayorA50;
        public static event Indicador IndicarMayorA80;
        public static event Indicador IndicarMayorA0;
        /// <summary>
        /// Calcula el porcentaje segun las cantidades recibidas por parametro
        /// </summary>
        /// <param name="cantidadFiltrada"></param>
        /// <param name="cantidadTotal"></param>
        /// <returns>float el porcentaje obtenido</returns>
        public static float CalcularPorcentaje(float cantidadFiltrada, float cantidadTotal)
        {
            float resultado = 0;
            resultado = cantidadFiltrada / cantidadTotal;
            resultado = resultado * 100;

            return resultado;
        }
        /// <summary>
        /// Calcula el porcentaje segun las cantidades recibidas por parametro y ademas lanza un evento si
        /// el resultado es mayor a 0, si es mayor a 25, si es mayor a 50 y si es mayor a 80
        /// </summary>
        /// <param name="cantidadFiltrada"></param>
        /// <param name="cantidadTotal"></param>
        /// <returns>float el porcentaje obtenido</returns>
        public static float CalcularPorcentajeConEvento(float cantidadFiltrada, float cantidadTotal)
        {
            float resultado = CalcularPorcentaje(cantidadFiltrada, cantidadTotal);
            if (resultado > 25 && resultado <= 50)
            {
                IndicarMayorA25.Invoke();
            }
            else if (resultado > 50 && resultado <= 80)
            {
                IndicarMayorA50.Invoke();
            }
            else if (resultado > 80)
            {
                IndicarMayorA80.Invoke();
            }
            else if (resultado >= 0 && resultado <= 25)
            {
                IndicarMayorA0.Invoke();
            }
            return resultado;
        }

    }
}
