using Carrito.Models;
using Carrito.Repositories.Carrito;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace Carrito.Repositories.Dapper.Carrito
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(string connectionString) : base(connectionString)
        {

        }
        public Usuario ValidateUser(string email, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@usuario",email);
                parameters.Add("@password", password);

                return connection.QueryFirstOrDefault<Usuario>("dbo.ValidateUser",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
