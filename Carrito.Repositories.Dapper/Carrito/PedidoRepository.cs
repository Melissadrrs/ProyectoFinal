using Carrito.Models;
using Carrito.Repositories.Carrito;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carrito.Repositories.Dapper.Carrito
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(string connectionString) : base(connectionString)
        {

        }
    }
}
