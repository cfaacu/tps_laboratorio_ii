using System;

namespace Entidades
{
    public static class Calculadora
    {
        #region Metodos
        /// <summary>
        /// Valida que el operador que recibe sea correcto
        /// </summary>
        /// <param name="operador">Operador a evaluar</param>
        /// <returns>Devuelve el char validado, en caso de ser invalido devuelve +</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }

        /// <summary>
        /// Hace el calculo segun el operador recibido
        /// </summary>
        /// <param name="num1">Numero 1 recibido</param>
        /// <param name="num2">Numero 2 recibido</param>
        /// <param name="operador">Operador a tener en cuenta para la operacion</param>
        /// <returns>El resultado en double</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorValidado = Calculadora.ValidarOperador(operador);
            switch (operadorValidado)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '/':
                    return num1 / num2;
                case '*':
                    return num1 * num2;
                default:
                    return 0;
            }
        }
        #endregion
    }
}
