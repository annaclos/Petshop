using Dapper;
using Petshop.Data;
using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;

namespace Petshop.src.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DapperContext _dapperContext;

        public ClienteRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task Create(Cliente clientes)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var sql = "INSERT INTO Clientes (name, number) VALUES (@name, @number)";
                await connection.ExecuteAsync(sql, clientes);
            }
        }

        public async Task Delete(int id)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var deletar = "DELETE FROM Clientes WHERE id=@id";
                await connection.ExecuteAsync(deletar, new { id });
            }
        }

        public async Task<Cliente?> Get(int id)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var get = @"SELECT Id,
                               name,
                               number
                        FROM Clientes
                        WHERE Id = @id";
                var clientes = await connection.QueryFirstOrDefaultAsync<Cliente>(get, new { id });
                return clientes;
            }
        }

        public async Task<List<Cliente>> List()
        {
            string query = @"SELECT Id,
                               name,
                               number
                        FROM Clientes";

            using (var connection = _dapperContext.CreateConnection())
            {
                var listaClientes = await connection.QueryAsync<Cliente>(query);
                return listaClientes.ToList();
            }
        }

        public async Task Update(int id, Cliente clientes)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var query = @"UPDATE Clientes 
                         SET name = @name,
                             number = @number 
                         WHERE Id = @id";
                await connection.ExecuteAsync(query, new { id, clientes.Name, clientes.Number });
            }
        }
    }
}

