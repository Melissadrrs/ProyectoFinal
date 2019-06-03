using Eventos.Models;
using Eventos.Repositories.Eventos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.Repositories.Dapper.Eventos
{
    public class EventoRepository : Repository<Evento>, IEventoRepository
    {
        public EventoRepository(string connectionString) : base(connectionString)
        {

        }
    }
}
