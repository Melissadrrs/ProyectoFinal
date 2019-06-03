using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaPedido { get; set; }
        public float CantidadTotal { get; set; }
        public float PrecioTotal { get; set; }
        public string Estado { get; set; }
    }
}
