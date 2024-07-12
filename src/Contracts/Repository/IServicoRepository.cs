using Petshop.Model.Data;

namespace Petshop.src.Contracts.Repository
{
    public interface IServicoRepository
    {
        Task Create(Servico servicos);
        Task Update(int id, Servico servicos);
        Task Delete(int id);
        Task<Servico> Get(int id);
        Task<List<Servico>> List();
        Task<IEnumerable<Servico>> GetServicoByCliente(int id);
    }
}
