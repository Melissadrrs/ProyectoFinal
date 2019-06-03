using Carrito.Models;
using Carrito.Repositories.Carrito;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carrito.Repositories.Dapper.Carrito
{
    public class TiendaRepository : Repository<Tienda>, ITiendaRepository
    {
        public TiendaRepository(string connectionString) : base(connectionString)
        {

        }
    }
}
