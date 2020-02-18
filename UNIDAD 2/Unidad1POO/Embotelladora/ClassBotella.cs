using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embotelladora
{
    class ClassBotella
    {
        //Atributos de la clase
       public int nivelLlenado, mililitrosVerificados;

        //Métodos de las clase
        public String verificadorLlenado()
        {
            String mensaje;
            mililitrosVerificados = nivelLlenado - 250;
            mensaje = "Te pasaste con: " + mililitrosVerificados + "ml";

            if (nivelLlenado == 250)
                mensaje = "EL llenado es exacto";
            
            else

            if (nivelLlenado < 250)
            {
                mililitrosVerificados = 250 - nivelLlenado;
                mensaje = "Te falta " + mililitrosVerificados + "ml";
            }

            return mensaje;
        }
    }
}
