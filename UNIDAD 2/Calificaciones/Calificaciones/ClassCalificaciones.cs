using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class ClassCalificaciones
    {
        //Atributos de la clase
        public double promedio;
        public int cal, aprobados, reprobados;
        int con = 0, suma;


        //Métodos de la clase
        public void RegCapCal()
        {
           if (cal>=70)
            {
                aprobados = aprobados + 1;
                suma = suma + cal;
            }
            else
            {
                reprobados = reprobados + 1;
                suma = suma + cal;
            }
           con++;
            promedio = suma/con;
               
        
        }

    }
}
