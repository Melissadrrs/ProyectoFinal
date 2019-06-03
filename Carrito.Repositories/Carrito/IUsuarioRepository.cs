using Carrito.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carrito.Repositories.Carrito
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario ValidateUser(string email, string password);
    }
}
