using System;

namespace Entidades
{
    public class Operando
    {
        #region Atributos
        private double numero;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public Operando() : this("0")
        {
        }

        /// <summary>
        /// Constructor que recibe un double
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que recibe un string
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que setea el valor en el atributo
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }
        #endregion

        #region Sobrecarga de Operadores
        /// <summary>
        /// Sobrecarga del operador resta
        /// </summary>
        /// <param name="n1">Numero1</param>
        /// <param name="n2">Numero2</param>
        /// <returns>El resultado en double</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador suma
        /// </summary>
        /// <param name="n1">Numero1</param>
        /// <param name="n2">Numero2</param>
        /// <returns>Resultado en double</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador multiplicacion
        /// </summary>
        /// <param name="n1">Numero1</param>
        /// <param name="n2">Numero2</param>
        /// <returns>Resultado en double</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador division
        /// </summary>
        /// <param name="n1">Numero1</param>
        /// <param name="n2">Numero2</param>
        /// <returns>Resultado en double</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            else
            {
                return double.MinValue;
            }

        }
        #endregion

        #region Metodos

        /// <summary>
        /// Valida que el numero recibido sea un numero binario
        /// </summary>
        /// <param name="binario">Numero a validar en string</param>
        /// <returns>True si es un binario o False si no lo es</returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Convierte el valor ingresado en decimal en caso de que sea binario
        /// </summary>
        /// <param name="binario">Numero en binario a convertir en formato string</param>
        /// <returns>Devuelve el numero convertido a decimal</returns>
        public string BinarioDecimal(string binario)
        {
            int numero = 0;
            int digito = 0;
            int divisor = 10;

            if (long.TryParse(binario, out long numeroDecimal))
            {
                if (this.EsBinario(binario))
                {
                    for (long i = numeroDecimal, j = 0; i > 0; i /= divisor, j++)
                    {
                        digito = (int)i % divisor;
                        numero += digito * (int)Math.Pow(2, j);
                    }
                    return numero.ToString();
                }
                else
                {
                    return "Valor Invalido";
                }
            }
            else
            {
                return "Valor Invalido";
            }

            
        }

        /// <summary>
        /// Convierte el valor ingresado a binario
        /// </summary>
        /// <param name="numero">Numero decimal a convertir en formato double</param>
        /// <returns>Devuelve el numero convertido a binario</returns>
        public string DecimalBinario(double numero)
        {
            long binario = 0;
            int divisor = 2;
            long digito = 0;

            if (numero >= 0)
            {
                for (long i = (long)numero % divisor, j = 0; numero > 0; numero /= divisor, i = (long)numero % divisor, j++)
                {
                    digito = (long)i % divisor;
                    binario += digito * (long)Math.Pow(10, j);
                }
                return binario.ToString();
            }
            else
            {
                return "Valor Invalido";
            }
        }

        /// <summary>
        /// Convierte el valor ingresado a binario
        /// </summary>
        /// <param name="strNumero">Numero decimal a convertir en formato string</param>
        /// <returns>Devuelve el numero convertido a binario</returns>
        public string DecimalBinario(string strNumero)
        {
            double numeroDouble = Convert.ToDouble(strNumero);
            return this.DecimalBinario(numeroDouble);
        }

        /// <summary>
        /// Valida que el operando ingresado sea valido
        /// </summary>
        /// <param name="strNumero">Operando a verificar</param>
        /// <returns>Devuelve el numero si es valido, si es invalido devuelve 0</returns>
        private double ValidarOperando(string strNumero)
        {
            strNumero = strNumero.Replace(".", ",");

            if (!(double.TryParse(strNumero, out double numero)))
            {
                return 0;
            }
            else
            {
                return numero;
            }
        }
        #endregion
    }
}
