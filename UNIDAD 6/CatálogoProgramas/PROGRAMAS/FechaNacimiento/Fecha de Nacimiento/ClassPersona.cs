using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha_de_Nacimiento
{
    class ClassPersona
    {
        //Atributos de la clase
        public int dia=0, mes=0, año=0;
        public int dias = 0, mess = 0, años = 0;
        public string me;

        //Métodos de la clase
        public void MayorEdad()
        {
            if(año-años>18)
            {
                me = "Es mayor de Edad";
            }
            else
                if(año-años==18)
            {
                if(mes>mess)
                {
                    me = "Es mayor de Edad";
                }
                else
                    if(mes==mess)
                {
                    if(dia>dias)
                    {
                        me = "Es mayor de Edad";
                    }
                    else
                        if(dia==dias)
                    {
                        me = "Es mayor de Edad";
                    }
                }
            }
        }
    }
}
