using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacaciones
{
    class ClassEmpleado
    {
        //Atributos de la clase
        public int años, vac;

        //Métodos de la clase
        public void Vacaciones()
        {
            if(años>=1 && años<=5)
            {
                vac = vac + 5;
            }
            else
                if(años>=6 && años<=10)
            {
                vac = vac + 10;
            }
            else
                if(años>10 && años<20)
            {
                vac = vac+años;
            }
            else
                if(años>=20 && años<=45)
            {
                vac = años + 2;
            }
        }
    }
}
