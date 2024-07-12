using Dapper;
using Petshop.Data;
using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;

namespace Petshop.src.Repository
{
    public class ServicoRepository : IServicoRepository
    {
        private readonly DapperContext _dapperContext;
        public ServicoRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        private List<Servico> servico = new List<Servico>
        {
            new Servico
            {
                Id = 1,
                Descricao = "Banho e Tosa",
                Valor = 59.9m
            }
        };
        public async Task Create(Servico servico)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var sql = "INSERT INTO Servico (Descricao, Valor) VALUES (@Descricao, @Valor)";
                await connection.ExecuteAsync(sql, servico);

            }
        }

        public async Task Delete(int id)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var sql = "DELETE FROM Servico WHERE Id = @Id";
                await connection.ExecuteAsync(sql, new { id });
            }
        }

        public async Task<Servico> Get(int id)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var query = @"SELECT 
                 Id   
                ,Descricao
                ,Valor
                FROM Servico WHERE Id = @Id";
                var servicos = await connection.QueryAsync<Servico>(query, new { id });
                if (servicos != null)
                {
                    return servicos.FirstOrDefault();
                }
                return null;
            }
        }

        public async Task<IEnumerable<Servico>> GetServicoByCliente(int Id)
        {

            string query = @"SELECT *
                            
              FROM Servico Where clienteId=@Id";

            using (var connection = _dapperContext.CreateConnection())
            {

                return await connection.QueryAsync<Servico>(query, new { Id });

            }

        }

        public async Task<List<Servico>> List()
        {
            string query = @"SELECT Id
              ,Descricao
              ,Valor
              FROM servico";

            using (var connection = _dapperContext.CreateConnection())
            {
                var listaServicos = await connection.QueryAsync<Servico>(query);
                return listaServicos.ToList();
            }
        }

        public async Task Update(int id, Servico servico)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                await connection.ExecuteAsync(
                    "UPDATE Servico SET Descricao=@Descricao, Valor = @Valor WHERE Id=@Id",
                    new { id, servico.Descricao });

            }
        }
    }
}