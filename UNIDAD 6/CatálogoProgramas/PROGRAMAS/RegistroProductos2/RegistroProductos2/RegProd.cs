using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroProductos2
{
    class RegProd
    {
        public string[,] NomProducto { get; set; }
        public int CantProd { get; set; }
        public int index { get; set; }
        public int Buscar { get; set; }


        public string Producto { get; set; }
        public int Cant { get; set; }
        public int[] Stock { get; set; }

        public RegProd()
        {
            Buscar = 0;
        }
    }
}
