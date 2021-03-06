using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// Escribe la frase segun el enumerado y el resultado recibido
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="enumerado"></param>
        /// <param name="resultado"></param>
        /// <returns>string la frase armada</returns>
        public static string Porcentaje(this string dato, EEstadoCivil enumerado, float resultado)
        {
            return $"El porcentaje de empleados cuyo estado civil es {enumerado} es del {resultado}%";
        }
        /// <summary>
        /// Escribe la frase segun el enumerado y el resultado recibido
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="edad"></param>
        /// <param name="resultado"></param>
        /// <returns>string la frase armada</returns>
        public static string Porcentaje(this string dato, int edad, float resultado)
        {
            return $"El porcentaje de empleados cuya edad es {edad} es del {resultado}%";
        }
        /// <summary>
        /// Escribe la frase segun el enumerado y el resultado recibido
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="enumerado"></param>
        /// <param name="resultado"></param>
        /// <returns>string la frase armada</returns>
        public static string Porcentaje(this string dato, ESexo enumerado, float resultado)
        {
            return $"El porcentaje de empleados cuyo sexo es {enumerado} es del {resultado}%";
        }
        /// <summary>
        /// Escribe la frase segun el enumerado y el resultado recibido
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="enumerado"></param>
        /// <param name="resultado"></param>
        /// <returns>string la frase armada</returns>
        public static string Porcentaje(this string dato, EPuesto enumerado, float resultado)
        {
            return $"El porcentaje de empleados cuyo puesto de {enumerado} es del {resultado}% ";
        }
        /// <summary>
        /// Escribe la frase segun el enumerado y el resultado recibido
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="enumerado"></param>
        /// <param name="resultado"></param>
        /// <returns>string la frase armada</returns>
        public static string Porcentaje(this string dato, ENacionalidad enumerado, float resultado)
        {
            return $"El porcentaje de empleados cuya nacionalidad es {enumerado} es del {resultado}% ";
        }
        /// <summary>
        /// Escribe la frase segun el enumerado y el resultado recibido
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="enumerado"></param>
        /// <param name="resultado"></param>
        /// <returns>string la frase armada</returns>
        public static string Porcentaje(this string dato, double sueldo, float resultado)
        {
            return $"El porcentaje de empleados cuyo sueldo es mayor a {sueldo} es del {resultado}% ";
        }
    }
}
