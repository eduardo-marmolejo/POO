using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    class ClassEmpleado
    {
        //Atributos de la clase
        private string nombre,zona,fecha;
        private double diastra,sueldo,pago;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public string Zona
        {
            set
            {
                zona = value;
            }
            get
            {
                return zona;
            }
        }

        public string Fecha
        {
            set
            {
                fecha = value;
            }
            get
            {
                return fecha;
            }
        }

        public double Diastra
        {
            set
            {
                diastra = value;
            }
            get
            {
                return diastra;
            }
        }

        public double Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        public double Pago
        {
            set
            {
                pago = value;
            }
            get
            {
                return pago;
            }
        }

        public ClassEmpleado()
        {
            Diastra = 0;
            Sueldo = 0;
        }

        
    }
}
