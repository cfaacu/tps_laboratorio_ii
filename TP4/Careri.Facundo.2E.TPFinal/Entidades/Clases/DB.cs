using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades.Clases
{
    public static class DB
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader reader;

        static DB()
        {
            conexion = new SqlConnection(@"Server=DESKTOP-0G8QMHH\SQLEXPRESS;Database=TP4_Careri_Facundo;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Empleado> RecuperarDatos()
        {
            List<Empleado> listAux = new List<Empleado>();

            comando.CommandText = "Select nombre,apellido,edad,sexo,nacionalidad,estadoCivil,puesto,sueldo,activo From Empleados";
            try
            {
                conexion.Open();

                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Empleado emp = new Empleado();
                    emp.Nombre = reader["nombre"].ToString();
                    emp.Apellido = reader["apellido"].ToString();
                    emp.Edad = int.Parse(reader["edad"].ToString());
                    emp.Sexo = (ESexo)int.Parse(reader["sexo"].ToString());
                    emp.Nacionalidad = (ENacionalidad)int.Parse(reader["nacionalidad"].ToString());
                    emp.EstadoCivil = (EEstadoCivil)int.Parse(reader["estadoCivil"].ToString());
                    emp.Puesto = (EPuesto)int.Parse(reader["puesto"].ToString());
                    emp.Sueldo = double.Parse(reader["sueldo"].ToString());
                    emp.Activo = bool.Parse(reader["activo"].ToString());

                    listAux.Add(emp);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return listAux;
        }

        public static void AgregarDatos(Empleado emp)
        {
            comando.CommandText = "INSERT INTO Empleados (nombre,apellido,edad,sexo,nacionalidad,estadoCivil,puesto,sueldo,activo) values (@Nombre,@Apellido,@Edad,@Sexo,@Nacionalidad,@EstadoCivil,@Puesto,@Sueldo,@Activo)";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Nombre", emp.Nombre);
            comando.Parameters.AddWithValue("@Apellido", emp.Apellido);
            comando.Parameters.AddWithValue("@Edad", emp.Edad);
            comando.Parameters.AddWithValue("@Sexo", (int)emp.Sexo);
            comando.Parameters.AddWithValue("@Nacionalidad", (int)emp.Nacionalidad);
            comando.Parameters.AddWithValue("@EstadoCivil", (int)emp.EstadoCivil);
            comando.Parameters.AddWithValue("@Puesto", (int)emp.Puesto);
            comando.Parameters.AddWithValue("@Sueldo", emp.Sueldo);
            comando.Parameters.AddWithValue("@Activo", emp.Activo);

            try
            {
                if(conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
