using Carrito.Repositories.Carrito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUsuarioRepository Usuarios { get; }
        IProductoRepository Productos { get; }
        IPedidoRepository Pedidos { get; }
        IDetallePedidoRepository DetallePedidos { get; }
        ITiendaRepository Tiendas { get; }
    }
}
