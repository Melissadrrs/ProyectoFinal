using Carrito.Repositories.Carrito;
using Carrito.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carrito.Repositories.Dapper.Carrito
{
    public class CarritoUnitOfWork : IUnitOfWork
    {
        public CarritoUnitOfWork(string connectionString)
        {
            Usuarios = new UsuarioRepository(connectionString);
            Productos = new ProductoRepository(connectionString);
            Pedidos = new PedidoRepository(connectionString);
            DetallePedidos = new DetallePedidoRepository(connectionString);
            Tiendas = new TiendaRepository(connectionString);
        }
        public IUsuarioRepository Usuarios { get; private set; }
        public IProductoRepository Productos { get; private set; }
        public IPedidoRepository Pedidos { get; private set; }
        public IDetallePedidoRepository DetallePedidos { get; private set; }
        public ITiendaRepository Tiendas { get; private set; }
    }
}
