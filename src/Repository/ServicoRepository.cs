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
        public void Create(Servico servicos)
        {
            servico.Add(servicos);
        }

        public bool Delete(int id)
        {
            var servicoDB = servico.FirstOrDefault(x=>x.Id == id);
            servico.Remove(servicoDB!);
            return true;
        }

        public Servico Get(int id)
        {
            return servico.FirstOrDefault(x => x.Id == id)!;

        }

        public async Task<IEnumerable<Servico>> GetServicoByCliente(int id)
        {
            string query = @"SELECT * FROM Servico Where clienteId=@Id"
            ;

            using (var connection = _dapperContext.CreateConnection())
            {
                return await connection.QueryAsync<Servico>(query, new { id });

            }
        }

        public List<Servico> List()
        {
            return servico;
        }

        public void Update(int id, Servico servicos)
        {
            var servicoDB = servico.FirstOrDefault(x => x.Id == id);
            servicoDB!.Valor = servicos.Valor;
            servicoDB.Descricao = servicos.Descricao;
        }
    }
}
