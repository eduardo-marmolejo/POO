using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class ClassTemperatura
    {
        //Atributos de la clase
        public double temp, temp2,num;
        public string temperatura;

        //Métodos de la clase
        public void Temperatura()
        {
            switch(temperatura)
            {
                case "Centígrados":
                    temp = (num * 1.8) + 32;
                    break;

                case "Fahrenheit":
                    temp2 = (num - 32) / 1.8;
                    break;
            }
        }
    }
}
