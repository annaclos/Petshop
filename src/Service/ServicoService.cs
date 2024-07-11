using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;
using Petshop.src.Contracts.Service;
using Petshop.src.Repository;

namespace Petshop.src.Service
{
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepository _servicosRepository;
        public ServicoService(IServicoRepository servicosRepository)
        {
            _servicosRepository = servicosRepository;
        }
        public void Create(Servico servicos)
        {
            _servicosRepository.Create(servicos);
        }

        public bool Delete(int id)
        {
            return _servicosRepository.Delete(id);
        }

        public Servico Get(int id)
        {
            return (_servicosRepository.Get(id));
        }

        public async Task<IEnumerable<Servico>> GetServicoByCliente(int id)
        {
            return await _servicosRepository.GetServicoByCliente(id);
        }

        public List<Servico> List()
        {
            return _servicosRepository.List();
        }

        public void Update(int id, Servico servicos)
        {
            _servicosRepository.Update(id, servicos);
        }
    }
}
