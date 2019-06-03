using Eventos.Models;
using Eventos.Repositories.Eventos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.Repositories.Dapper.Eventos
{
    public class ComentarioRepository:Repository<Comentario>, IComentarioRepository
    {
        public ComentarioRepository(string connectionString) : base(connectionString)
        {

        }
    }
}
