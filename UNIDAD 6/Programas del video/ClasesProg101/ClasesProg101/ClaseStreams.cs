using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesProg101
{
    class ClaseStreams
    {
        //Este método crea unn archivo llamado archivo en formato .txt y se le asigna u contenido predeterminado
        public void Crear()
        {
            using (Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read))
            {
                //Obtenemos el número de bytes
                long quantity = fs.Length;
                Console.WriteLine($"El archivo tiene una longitud de {quantity} bytes");

                for (long count = 0; count < quantity; count++)
                {
                    fs.Seek(count, SeekOrigin.Begin);
                    int valor = fs.ReadByte();
                    Console.WriteLine($"Posición {count}: {(char)valor}");
                }

                //MUY IMPORTANTE: Cerrar el Stream
                fs.Close();

                Console.ReadKey();
            }
        }
    }
}
