using Petshop.Model.Data;

namespace Petshop.src.Contracts.Service
{
    public interface IServicoService
    {
        void Create(Servico servicos);
        void Update(int id, Servico servicos);
        bool Delete(int id);
        Servico Get(int id);
        List<Servico> List();
        Task<IEnumerable<Servico>> GetServicoByCliente(int id);
    }
}
