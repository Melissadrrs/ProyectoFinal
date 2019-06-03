using Carrito.Models;
using Carrito.Repositories.Carrito;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carrito.Repositories.Dapper.Carrito
{
    public class DetallePedidoRepository : Repository<DetallePedido>, IDetallePedidoRepository
    {
        public DetallePedidoRepository(string connectionString) : base(connectionString)
        {

        }
    }
}
