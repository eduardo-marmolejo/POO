using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_Mayor_y_Menor
{
    class MayorMenor
    {
        public int Mayor { get; set; }
        public int Menor { get; set; }
        public int[] NumCant { get; set; }
        public int Cant { get; set; }

        public string CalcularMay(int Mayor, string maymer, int Menor)
        {
            int m = 0;
            int NumeroMay = 0;
            int r = 0;
            int NumeroMen = 0;
            for (int i = 0; i < NumCant.GetLength(0); i++)
            {
                if (NumCant[i] > Mayor)
                {
                    Mayor = NumCant[i];
                    m = Mayor;
                }

                if (NumCant[i] < Mayor)
                {
                    Menor = NumCant[i];
                    r = Menor;
                }

            }
            maymer = "El numero mayor es: " + m + "\nEl numero menor es: " + r;
            return maymer;
        }
    }
}
