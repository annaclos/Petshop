using Dapper;
using Microsoft.Data.SqlClient;
using Petshop.Data;
using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;

namespace Petshop.src.Repository
{
    public class AnimaisRepository : IAnimalRepository
    {
        private readonly DapperContext _dapperContext;

        public AnimaisRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public Task Create(Animal animal)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Animal> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Animal>> List()
        {
            string query = @"SELECT Id,
                           Raca,
                           Especie
                          FROM Animal";

            using(var connection = _dapperContext.CreateConnection())
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
                    query,new {id, animal.Raca, animal.Especie});
            }
        }
    }
}
