using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class ClassPersonas
    {
        //Atributos de la clase
        public string nom, paterno, materno, tipo, estados,nombre,Paterno,Materno;
        public int año, mes, dia, añoActual, mesActual, diaActual;
        public int conEdad = 0, conNayarit=0, conAlumno = 0, conMaestros = 0, conAdmin = 0;

        //Métodos de la clase
        public void RegPersonas()
        {
            nom = nombre;
            paterno = Paterno;
            materno = Materno;
        }

        public void Nayarit()
        {
            if (estados == "Nayarit")
            {
                conNayarit++;
            }
        }

        public void Tipasos()
        {
            switch (tipo)
            {
                case "Alumno":
                    conAlumno++;
                    break;

                case "Maestro":
                    conMaestros++;
                    break;

                case "Administrativo":
                    conAdmin++;
                    break;
            }
        }

        public void Edad()
        {
            if(añoActual-año>18)
            {
                conEdad++;
            }
            else
                if(añoActual-año==18)
            {
                if(mesActual<mes)
                {
                    conEdad++;
                }
                else
                    if(diaActual<dia)
                {
                    conEdad++;
                }
            }

        }
    }
}
