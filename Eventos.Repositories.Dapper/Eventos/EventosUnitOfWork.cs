using Eventos.Repositories.Eventos;
using Eventos.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.Repositories.Dapper.Eventos
{
    public class EventosUnitOfWork : IUnitOfWork
    {
        public EventosUnitOfWork(string connectionString)
        {
            Usuarios = new UsuarioRepository(connectionString);
            Comentarios = new ComentarioRepository(connectionString);
            Eventos = new EventoRepository(connectionString);
        }
        public IUsuarioRepository Usuarios { get; private set; }
        public IComentarioRepository Comentarios { get; private set; }
        public IEventoRepository Eventos { get; private set; }
  
    }
}
