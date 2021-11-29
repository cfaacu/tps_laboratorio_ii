using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Datos
    {
        public static List<Empleado> listaEmpleados;

        static Datos()
        {
            listaEmpleados = new List<Empleado>();
        }

        /// <summary>
        /// Calcula todos los mayores de edad segun el parametro recibido
        /// </summary>
        /// <param name="edad"></param>
        /// <returns>List<Empleado> con todos los que cumplen la condicion</returns>
        public static List<Empleado> CalcularEdadMayorA(int edad, List<Empleado> lista)
        {
            List<Empleado> listaAux = new List<Empleado>();
            if(lista.Count != 0)
            {
                listaAux = lista.FindAll((p) => p.Edad > edad);
            }
            else
            {
                throw new ListVaciaException("La lista no contienen datos");
            }
            return listaAux;
        }
        /// <summary>
        /// Calcula todos los que coincidan el sexo segun el parametro recibido
        /// </summary>
        /// <param name="sexo"></param>
        /// <returns>List<Empleado> con todos los que cumplen la condicion</returns>
        public static List<Empleado> CalcularSexo(ESexo sexo, List<Empleado> lista)
        {
            List<Empleado> listaAux = new List<Empleado>();
            if(lista.Count != 0)
            {
                listaAux = lista.FindAll((p) => p.Sexo == sexo);
            }
            else
            {
                throw new ListVaciaException("Las listas no contienen datos");
            }

            return listaAux;
        }
        /// <summary>
        /// Calcula todos los que coincidan la nacionalidad segun el parametro recibido
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <returns>List<Empleado> con todos los que cumplen la condicion</returns>
        public static List<Empleado> CalcularNacionalidad(ENacionalidad nacionalidad, List<Empleado> lista)
        {
            List<Empleado> listaAux = new List<Empleado>();
            if(lista.Count != 0)
            {
                listaAux = lista.FindAll((p) => p.Nacionalidad == nacionalidad);
            }
            else
            {
                throw new ListVaciaException("Las listas no contienen datos");
            }

            return listaAux;
        }
        /// <summary>
        /// Calcula todos los que coincidan el estado civil segun el parametro recibido
        /// </summary>
        /// <param name="estadoCivil"></param>
        /// <returns>List<Empleado> con todos los que cumplen la condicion</returns>
        public static List<Empleado> CalcularEstadoCivil(EEstadoCivil estadoCivil, List<Empleado> lista)
        {
            List<Empleado> listaAux = new List<Empleado>();
            if(lista.Count != 0)
            {
                listaAux = lista.FindAll((p) => p.EstadoCivil == estadoCivil);
            }
            else
            {
                throw new ListVaciaException("Las listas no contienen datos");
            }

            return listaAux;
        }


        /// <summary>
        /// Calcula todos los que coincida el puesto segun el parametro recibido
        /// </summary>
        /// <param name="puesto"></param>
        /// <returns>List<Empleado> con todos los que cumplen la condicion</returns>
        public static List<Empleado> CalcularPuesto(EPuesto puesto, List<Empleado> lista)
        {
            List<Empleado> listaAux = new List<Empleado>();
            if(lista.Count != 0)
            {
            listaAux = lista.FindAll((p) => p.Puesto == puesto);
            }
            else
            {
                throw new ListVaciaException("Las listas no contienen datos");
            }

            return listaAux;
        }
        /// <summary>
        /// Calcula todos los que su sueldo sea mayor al parametro recibido
        /// </summary>
        /// <param name="sueldo"></param>
        /// <returns>List<Empleado> con todos los que cumplen la condicion</returns>
        public static List<Empleado> CalcularSueldoMayorA(double sueldo, List<Empleado> lista)
        {
            List<Empleado> listaAux = new List<Empleado>();
            if(lista.Count != 0)
            { 
                listaAux = lista.FindAll((p) => p.Sueldo > sueldo);
            }
            else
            {
                throw new ListVaciaException("Las listas no contienen datos");
            }
            return listaAux;
        }
        /// <summary>
        /// Calcula todos los qque su puesto este activo
        /// </summary>
        /// <returns>List<Empleado> con todos los que cumplen la condicion</returns>
        public static List<Empleado> CalcularPuestosActivos(List<Empleado> lista)
        {
            List<Empleado> listaAux = new List<Empleado>();
            if (lista.Count != 0)
            {
                listaAux = lista.FindAll((p) => p.Activo == true);
            }
            else
            {
                throw new ListVaciaException("Las listas no contiene datos");
            }

            return listaAux;
        }

    }
}
