using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    class ClassAlumno:ClassPersona
    {
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Curp { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string NumControl { get; set; }
        public string Carrera { get; set; }
        public string[,] MateriasCal { get; set; }

        public ClassAlumno()
        {
            Cant = 0;

        }
    }
}
