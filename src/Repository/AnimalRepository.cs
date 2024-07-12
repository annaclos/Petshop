using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Petshop.Data;
using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;

namespace Petshop.src.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly DapperContext _dapperContext;

        public AnimalRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task Create(Animal animal)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var sql = "INSERT INTO Animal (Raca, Especie) VALUES (@Raca, @Especie)";
                await connection.ExecuteAsync(sql, animal);
            }
        }

        public async Task Delete(int id)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var deletar = "DELETE FROM Animal WHERE id=@id";
                await connection.ExecuteAsync(deletar, new { id });
            }
        }

        public async Task<Animal?> Get(int id)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var get = @"SELECT Id,
                           Raca,
                           Especie
                          FROM Animal";
                var animais = await connection.QueryAsync<Animal>(get, new { id });
                if (animais != null)
                {
                    return animais.FirstOrDefault();
                }
                return null;
            }
        }
        public async Task<IEnumerable<Animal>> GetAnimalByCliente(int id)
        {
            string query = @"SELECT Id
                                ,raca
                                ,especie
                                ,clienteId
                                FROM Animal Where clienteId=@Id";

            using (var connection = _dapperContext.CreateConnection())
            {
                return await connection.QueryAsync<Animal>(query, new { id });

            }
        }

        public async Task<List<Animal>> List()
        {
            string query = @"SELECT Id,
                           Raca,
                           Especie
                          FROM Animal";

            using (var connection = _dapperContext.CreateConnection())
            {
                var listaAnimais = await connection.QueryAsync<Animal>(query);
                return listaAnimais.ToList();
            }
        }
        public async Task Update(int id, Animal animal)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var query = @"UPDATE Animal 
                            SET Raca = @Raca,
                                Especie = @Especie 
                            WHERE Id = @Id";
                await connection.ExecuteAsync(
                    query, new { id, animal.Raca, animal.Especie });
            }
        }
    }
}
