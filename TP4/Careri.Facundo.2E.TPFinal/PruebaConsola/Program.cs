using Entidades;
using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos.listaEmpleados.Clear();
            List<Empleado> listaAux1;
            List<Empleado> listaAux2;
            List<Empleado> listaAux3;
            string pathLecturaXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivo.xml");
            string pathTxt = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FILTRO3.txt");
            string pathEscrituraXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FILTRO2.xml");
            string pathJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FILTRO1.json");
            Serializadora<List<Empleado>> serXml = new Serializadora<List<Empleado>>(ETipo.XML);
            Serializadora<List<Empleado>> serJson = new Serializadora<List<Empleado>>(ETipo.JSON);
            ArchivoTexto txt = new ArchivoTexto();
            Analisis.IndicarMayorA0 += Vacio;
            Analisis.IndicarMayorA25 += Vacio;
            Analisis.IndicarMayorA50 += Vacio;
            Analisis.IndicarMayorA80 += Vacio;

            Console.WriteLine("----------LEVANTO LOS DATOS DE LA BASE DE DATOS----------");
            try
            {
                Datos.listaEmpleados = DB.RecuperarDatos();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("PULSE PARA CONTINUAR");
            Console.ReadKey();

            Console.WriteLine("----------ESCRIBO LOS DATOS DE LA LISTA----------");
            foreach (Empleado item in Datos.listaEmpleados)
            {
                Console.WriteLine($"{item.Nombre}");
                Console.WriteLine($"{item.Apellido}");
                Console.WriteLine($"{item.Edad}");
                Console.WriteLine($"{item.Sexo}");
                Console.WriteLine($"{item.Nacionalidad}");
                Console.WriteLine($"{item.EstadoCivil}");
                Console.WriteLine($"{item.Puesto}");
                Console.WriteLine($"{item.Sueldo}");
                Console.WriteLine($"{item.Activo}");
                Console.WriteLine("");
            }
            Console.WriteLine("PULSE PARA CONTINUAR");
            Console.ReadKey();

            Console.WriteLine("----------AGREGO EL SIGUIENTE EMPLEADO A LA LISTA----------");

            Empleado emp1 = new Empleado("Pepe", "Alonzo", 65, ESexo.Hombre, ENacionalidad.Chile, EEstadoCivil.Casado, EPuesto.Atencion, 15000, true);
            Datos.listaEmpleados.Add(emp1);

            Console.WriteLine($"{emp1.Nombre}");
            Console.WriteLine($"{emp1.Apellido}");
            Console.WriteLine($"{emp1.Edad}");
            Console.WriteLine($"{emp1.Sexo}");
            Console.WriteLine($"{emp1.Nacionalidad}");
            Console.WriteLine($"{emp1.EstadoCivil}");
            Console.WriteLine($"{emp1.Puesto}");
            Console.WriteLine($"{emp1.Sueldo}");
            Console.WriteLine($"{emp1.Activo}");
            Console.WriteLine("");

            Console.WriteLine("----------FILTRO LA LISTA POR MAYORES A 45 ANIOS Y LO GUARDO EN JSON EN EL BIN CON EL NOMBRE FILTRO1.json----------");

            listaAux1 = Datos.CalcularEdadMayorA(45);
            try
            {
            serJson.Escribir(listaAux1, pathJson);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("PULSE PARA CONTINUAR");
            Console.ReadKey();

            Console.WriteLine("----------MUESTRO EL ANALISIS----------");
            Console.WriteLine($"El porcentaje de mayores a 45 anios es del {Analisis.CalcularPorcentaje(listaAux1.Count, Datos.listaEmpleados.Count)}%");
            Console.WriteLine("PULSE PARA CONTINUAR");
            Console.ReadKey();

            Console.WriteLine("----------FILTRO LA LISTA POR MUJERES Y LO GUARDO EN XML EN EL BIN CON EL NOMBRE FILTRO2.xml----------");

            listaAux2 = Datos.CalcularSexo(ESexo.Mujer);
            try
            {
            serXml.Escribir(listaAux2, pathEscrituraXml);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("PULSE PARA CONTINUAR");
            Console.ReadKey();

            Console.WriteLine("----------MUESTRO EL ANALISIS----------");
            Console.WriteLine($"El porcentaje de mujeres es del {Analisis.CalcularPorcentaje(listaAux2.Count, Datos.listaEmpleados.Count)}%");
            Console.WriteLine("PULSE PARA CONTINUAR");
            Console.ReadKey();
            Console.WriteLine("----------FILTRO LA LISTA POR ARGENTINOS Y LO GUARDO EN TXT EN EL BIN CON EL NOMBRE FILTRO3.txt----------");

            listaAux3 = Datos.CalcularSexo(ESexo.Mujer);
            StringBuilder dato = new StringBuilder();
            foreach (Empleado item in listaAux3)
            {

                dato.AppendLine($"{item.Nombre}");
                dato.AppendLine($"{item.Apellido}");
                dato.AppendLine($"{item.Edad}");
                dato.AppendLine($"{item.Sexo}");
                dato.AppendLine($"{item.Nacionalidad}");
                dato.AppendLine($"{item.EstadoCivil}");
                dato.AppendLine($"{item.Puesto}");
                dato.AppendLine($"{item.Sueldo}");
                dato.AppendLine($"{item.Activo}");
                dato.AppendLine($"");
            }
            try
            {
            txt.Escribir(dato.ToString(), pathTxt);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----------MUESTRO EL ANALISIS----------");
            Console.WriteLine($"El porcentaje de argentinos es del {Analisis.CalcularPorcentaje(listaAux3.Count, Datos.listaEmpleados.Count)}%");
            Console.WriteLine("PULSE PARA SALIR");
            Console.ReadKey();

            Datos.listaEmpleados.Clear();
        }
 
        static void Vacio()
        {
        }
    }
}
