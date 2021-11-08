using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EPuesto
    {
        Atencion,
        Administrativo,
        Repositor,
        RRHH,
        CM
    }
    public class Empleado: Persona
    {
        EPuesto puesto;
        double sueldo;
        bool activo;

        [JsonConstructor]
        public Empleado()
        {

        }
        public Empleado(string nombre, string apellido, int edad, ESexo sexo, ENacionalidad nacionalidad, EEstadoCivil estadoCivil, EPuesto puesto, double sueldo, bool activo):base(nombre,apellido,edad,sexo,nacionalidad,estadoCivil)
        {
            this.Puesto = puesto;
            this.Sueldo = sueldo;
            this.Activo = activo;
        }

        public EPuesto Puesto
        {
            get
            {
                return this.puesto;
            }
            set
            {
                this.puesto = value;
            }
        }
        public double Sueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                if (value > 0 && value < 500000)
                {
                    this.sueldo = value;
                }
                else
                {
                    throw new DatosInvalidosException("Sueldo invalido");
                }
            }
        }
        public bool Activo
        {
            get
            {
                return this.activo;
            }
            set
            {
                this.activo = value;
            }
        }
    }
}
