using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizSumaFCD
{
    class MatrizSumas
    {
        public int[] SumaFilas { get; set; }
        public int[] SumaColumnas { get; set; }
        public int[] Diagonal { get; set; }
        public int[,] MatrizBidi { get; set; }

        public void SumaFila()
        {
            //variable para introducir el indice en el que va el arreglo unidimensional
            int p = 0;
            for (int i = 0; i < MatrizBidi.GetLength(1); i++)
            {
                //variable para sumar las columnas de cada fila
                int suma = 0;
                //variable para acumular el resultdo de la suma
                int acum = 0;
                //Espacio para acumular el resultado obtenido de la suma de las columnas de cada fila
                for (int j = 0; j < MatrizBidi.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(MatrizBidi[j, i]);
                    acum += suma;
                }
                //asignar lo obtenido al indice correspondiente del arreglo de la suma de los puntajes
                SumaFilas[p] = acum;
                //contador para P
                p++;
            }
        }

        public void SumaColumna()
        {
            //variable para introducir el indice en el que va el arreglo unidimensional
            int p = 0;
            for (int i = 0; i < MatrizBidi.GetLength(0); i++)
            {
                //variable para sumar las columnas de cada fila
                int suma = 0;
                //variable para acumular el resultdo de la suma
                int acum = 0;
                //Espacio para acumular el resultado obtenido de la suma de las columnas de cada fila
                for (int j = 0; j < MatrizBidi.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(MatrizBidi[i, j]);
                    acum += suma;
                }
                //asignar lo obtenido al indice correspondiente del arreglo de la suma de los puntajes
                SumaColumnas[p] = acum;
                //contador para P
                p++;
            }
        }

        public string SumaDiagonal()
        {
            string SumaDiagonales = "";
            int acum = 0;
            //variable para introducir el indice en el que va el arreglo unidimensional

            for (int i = 0; i < MatrizBidi.GetLength(0); i++)
            {
                //variable para sumar las columnas de cada fila
                int suma = 0;
                //variable para acumular el resultdo de la suma

                //Espacio para acumular el resultado obtenido de la suma de las columnas de cada fila
                for (int j = 0; j < MatrizBidi.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        suma = Convert.ToInt32(MatrizBidi[i, j]);
                        acum += suma;
                    }

                }
            }
            //asignar lo obtenido al indice correspondiente del arreglo de la suma de los puntajes
            SumaDiagonales = Convert.ToString(acum);
            return SumaDiagonales;
        }


    }
}
