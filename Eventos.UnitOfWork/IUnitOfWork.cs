
using Eventos.Repositories.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.UnitOfWork
{
    public interface IUnitOfWork
    {
        IEventoRepository Eventos { get; }
        IComentarioRepository Comentarios { get; }
        IUsuarioRepository Usuarios { get; }
    }
}
