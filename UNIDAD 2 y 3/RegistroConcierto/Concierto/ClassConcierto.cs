using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto
{
    class ClassConcierto
    {
        //Atributos de clase
        public int bb,nn,adu,te,num,num2,num3,num4;
        public string persona;

        //Métodos de la clase
        public void RegConcierto()
        {
            switch(persona)
            {
                case "Bebes":
                    bb = bb + num;
                break;

                case "Niños":
                    nn = nn + num2;
                    
                break;

                case "Adultos":
                    adu = adu + num3;
                    
                break;

                case "Tercera Edad":
                    te = te + num4;
                    
                break;
            }
        }
    }
}
