using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Vehículos
{
    class ClassVehículo
    {

        //Atributos de la clase
        public string tipocombus, color, sonido;
        public int numllan, numpuertas, numventanas;
        //Métodos de la clase
        
        /*Constructor de la clase, es un método que se llama ifual que la clase
          y se ejecuta automáticamente al crear el objeto*/

        public ClassVehículo()
        {
            tipocombus = "";
            color = "Blanco";
            numllan = 0;
            numpuertas = 0;
            numventanas = 0;
        }

        public void arrancarMotor()
        {
            //retrun "Se arrancó el motor"+ sonido;
            //return "Se arrancó el motor " + sonido;

        }

        public string pararMotor(string sonido)
        {
            return "Se detuvo el motor " + sonido;
        }
    }
}
