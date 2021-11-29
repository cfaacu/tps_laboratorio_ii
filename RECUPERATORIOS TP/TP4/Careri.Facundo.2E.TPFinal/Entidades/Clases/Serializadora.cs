using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public enum ETipo
    {
        XML,
        JSON
    }
    public class Serializadora<T> : IArchivo<T> where T : class
    {
        private ETipo tipo;

        public Serializadora(ETipo tipo)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Escribe un archivo Json o Xml segun lo recibido en el constructor, guarda el dato en el path recibido
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="path"></param>
        public void Escribir(T dato, string path)
        {
            try
            {
                if (this.tipo == ETipo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextWriter xml = new XmlTextWriter(path, Encoding.UTF8))
                        {
                            xml.Formatting = Formatting.Indented;
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            xmlSerializer.Serialize(xml, dato);
                        }
                    }
                    else
                    {
                        throw new Exception("Extension invalida para tipo XML");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        ArchivoTexto json = new ArchivoTexto();
                        JsonSerializerOptions option = new JsonSerializerOptions();
                        option.WriteIndented = true;
                        json.Escribir(JsonSerializer.Serialize(dato, typeof(T),option),path);
                    }
                    else
                    {
                        throw new Exception("Extension invalida para tipo JSON");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Lee un archivo Json o Xml segun el parametro recibido
        /// </summary>
        /// <param name="path"></param>
        /// <returns>T Es generico, devuelve segun la instancia el resultado leido del archivo</returns>
        public T Leer(string path)
        {
            try
            {
                if (this.tipo == ETipo.XML)
                {
                    if (Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextReader xmlTextReader = new XmlTextReader(path))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            return ((T)xmlSerializer.Deserialize(xmlTextReader));

                        }
                    }
                    else
                    {
                        throw new Exception("Extension invalida");
                    }
                }
                else
                {
                    T asd;
                    if (Path.GetExtension(path) == ".json")
                    {
                        string objetoJson = File.ReadAllText(path);

                        asd = JsonSerializer.Deserialize<T>(objetoJson);
                        return asd;
                    }
                    else
                    {
                        throw new Exception("Extension invalida");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
