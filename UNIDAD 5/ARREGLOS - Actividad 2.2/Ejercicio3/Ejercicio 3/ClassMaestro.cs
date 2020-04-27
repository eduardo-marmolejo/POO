using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class ClassMaestro:ClassPersona
    {
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Curp { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string NumMaestro { get; set; }
        public int Sueldo { get; set; }
        public string[,] MateriasImpartidas{ get; set; }

        public ClassMaestro()
        {
            Cant2 = 0;
        }
    }
}
