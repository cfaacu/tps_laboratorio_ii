using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Entidades
{
    public enum ESexo
    {
        Mujer,
        Hombre,
        Otros
    }
    public enum ENacionalidad
    {
        Argentina,
        Chile,
        Colombia,
        EEUU,
        Mexico,
        Francia
    }
    public enum EEstadoCivil
    {
        Casado,
        Soltero,
        Divorciado,
        Viudo
    }

    [XmlInclude(typeof(Empleado))]
    public abstract class Persona
    {
        string nombre;
        string apellido;
        int edad;
        ESexo sexo;
        ENacionalidad nacionalidad;
        EEstadoCivil estadoCivil;

        [JsonConstructor]
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, int edad, ESexo sexo, ENacionalidad nacionalidad, EEstadoCivil estadoCivil)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Edad = edad;
            this.Nacionalidad = nacionalidad;
            this.EstadoCivil = estadoCivil;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if(Validacion.ValidarSoloLetras(value))
                {
                    this.nombre = value;
                }
                else
                {
                    throw new DatosInvalidosException("Nombre incorrecto");
                }
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (Validacion.ValidarSoloLetras(value))
                {
                    this.apellido = value;
                }
                else
                {
                    throw new DatosInvalidosException("Apellido incorrecto");
                }
            }
        }
        public ESexo Sexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if(value >= 18 && value < 112)
                {
                    this.edad = value;
                }
                else
                {
                    throw new DatosInvalidosException("Edad invalida");
                }
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        public EEstadoCivil EstadoCivil
        {
            get
            {
                return this.estadoCivil;
            }
            set
            {
                this.estadoCivil = value;
            }
        }
    }
}
