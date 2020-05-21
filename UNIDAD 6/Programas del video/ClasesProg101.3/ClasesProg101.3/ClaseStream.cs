using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesProg101._3
{
    class ClaseStream
    {
        //Este método crea unn archivo llamado archivo en formato .txt y se le asigna u contenido predeterminado
        public void Crear()
        {
            using (Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read))
            {
                //Obtenemos el número de bytes
                long quantity = fs.Length;
                Console.WriteLine($"El archivo tiene una longitud de {quantity} bytes");

                int valor = 0;
                
                while (valor!=-1)
                {
                    valor = fs.ReadByte();
                    if (valor != -1)
                    {
                        Console.WriteLine($"{(char)valor}");
                    }
                }

                //MUY IMPORTANTE: Cerrar el Stream
                fs.Close();

                Console.ReadKey();
            }
        }
    }
}
