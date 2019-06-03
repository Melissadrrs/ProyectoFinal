using Carrito.Models;
using Carrito.Repositories.Carrito;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carrito.Repositories.Dapper.Carrito
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        public ProductoRepository(string connectionString) : base(connectionString)
        {

        }
    }
}
