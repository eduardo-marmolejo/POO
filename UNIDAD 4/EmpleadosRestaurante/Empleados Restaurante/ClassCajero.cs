using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    class ClassCajero:ClassEmpleado
    {
        private string numCaja;

        public string NumCaja
        {
            set
            {
                numCaja = value;
            }
            get
            {
                return numCaja;
            }
        }

        public void calcularSueldo()
        {
            switch (NumCaja)
            {
                case "1":
                    Sueldo = (Pago * Diastra) + ((Pago * Diastra)*.03);
                    break;

                case "2":
                    Sueldo = (Pago * Diastra);
                    break;

            }
        }
    }
}
