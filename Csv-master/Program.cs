using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string[]> datos = new List<string[]>
        {
            new string[] {"Nombre", "Edad", "Ciudad"},
            new string[] {"Juan", "25", "Madrid"},
            new string[] {"María", "30", "Barcelona"},
            new string[] {"Carlos", "28", "Valencia"}
        };

            // Ruta del archivo CSV
            string rutaArchivo = @"C:\\Users\\Orozco\\Desktop\\mi_archivo.csv";

            // Escribir en el archivo CSV
            EscribirCSV(datos, rutaArchivo);

            Console.WriteLine("Archivo CSV generado exitosamente.");
        }

        static void EscribirCSV(List<string[]> datos, string ruta)
        {
            using (StreamWriter writer = new StreamWriter(ruta))
            {
                foreach (string[] linea in datos)
                {
                    writer.WriteLine(string.Join(",", linea));
                }
            }
        }
    }
}
