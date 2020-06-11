using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidimensionales1_12
{
    class Bidi1
    {
        public void Archvio()
        {
            using (Stream fs = new FileStream("./Datos1.txt", FileMode.Create, FileAccess.Write))
            {
                int[,] notas1 = new int[2, 2]; //2 bloques de datos
                notas1[0, 0] = 1;
                notas1[0, 1] = 2;
                notas1[1, 0] = 3;
                notas1[1, 1] = 4;

                int[,] notas2 = //2 bloques de 10 datos, prefijados
                {
                {1,2,3,4,5,6,7,8,9,10 },
                {11,12,13,14,15,16,17,18,19,20 }
                };

                Console.WriteLine("La nota1 del segundo alumno del grupo 1 es {0}", notas1[0, 1]);
                Console.WriteLine("La nota2 del tercer alumno del grupo 1 es {0}", notas2[0, 2]);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("La nota1 del segundo alumno del grupo 1 es {0}", notas1[0, 1]);
                    sw.WriteLine("La nota2 del tercer alumno del grupo 1 es {0}", notas2[0, 2]);
                }
                //Muy importante cerrar el Stream
                fs.Close();
            }
            Console.ReadKey();
        }
    }
}
