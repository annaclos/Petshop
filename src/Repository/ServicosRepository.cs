using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;

namespace Petshop.src.Repository
{
    public class ServicosRepository : IServicosRepository
    {
        private List<Servicos> servico = new List<Servicos>
        {
            new Servicos
            {
                id = 1,
                descricao = "Banho e Tosa",
                valor = 59.9m
            }
        };
        public void Create(Servicos servicos)
        {
            servico.Add(servicos);
        }

        public bool Delete(int id)
        {
            var servicoDB = servico.FirstOrDefault(x=>x.id == id);
            servico.Remove(servicoDB);
            return true;
        }

        public Servicos Get(int id)
        {
            return servico.FirstOrDefault(x => x.id == id)!;

        }

        public List<Servicos> List()
        {
            return servico;
        }

        public void Update(int id, Servicos servicos)
        {
            var servicoDB = servico.FirstOrDefault(x => x.id == id);
            servicoDB.valor = servicos.valor;
            servicoDB.descricao = servicos.descricao;
        }
    }
}
