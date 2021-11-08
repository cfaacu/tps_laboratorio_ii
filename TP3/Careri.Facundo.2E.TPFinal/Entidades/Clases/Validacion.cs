using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validacion
    {
        /// <summary>
        /// Valida que el string recibido solo contenga letras
        /// </summary>
        /// <param name="stringAValidar"></param>
        /// <returns>true si es correcto o false si es incorrecto</returns>
        public static bool ValidarSoloLetras(string stringAValidar)
        {
            stringAValidar = stringAValidar.ToLower();
            if(string.IsNullOrEmpty(stringAValidar))
            {
                return false;
            }
            for (int i = 0; i < stringAValidar.Length; i++)
            {
                if (!(stringAValidar[i] >= 'a' && stringAValidar[i] <= 'z' || stringAValidar[i] == ' '))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Valida que todos los campos esten llenos y con informacion valida
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="estadoCivil"></param>
        /// <param name="puesto"></param>
        /// <param name="sueldo"></param>
        /// <param name="activo"></param>
        /// <returns>true si es todo correcto o lanza una exception DatosInvalidosException si no lo es</returns>
        public static bool ValidarCampos(string nombre, string apellido, int edad, ESexo sexo, ENacionalidad nacionalidad, EEstadoCivil estadoCivil, EPuesto puesto, double sueldo, bool activo)
        {
            if (!string.IsNullOrEmpty(nombre) && Validacion.ValidarSoloLetras(nombre))
            {
                if (!string.IsNullOrEmpty(apellido) && Validacion.ValidarSoloLetras(apellido))
                {
                    if (edad > 18 && edad < 112)
                    {
                        if (sueldo > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            throw new DatosInvalidosException("Error al cargar los datos");
        }

    }
}
