using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoTexto:IArchivo<string>
    {
        /// <summary>
        /// Escribe el dato que recibe en un archivo.txt en el path recibido
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="path"></param>
        public void Escribir(string dato, string path)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLine(dato);
                }
            }
            catch(Exception e)
            {
                throw;
            }
        }

        /// <summary>
        /// Leer un archivo.txt de el path recibido
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string Leer(string path)
        {
            string stringAux = string.Empty;

            try
            {
                using(StreamReader streamReader = new StreamReader(path))
                {
                    while(!streamReader.EndOfStream)
                    {
                        stringAux += $"{streamReader.ReadLine()}\n";
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return stringAux;
        }
    }
}
