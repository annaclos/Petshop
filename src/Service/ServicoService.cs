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
        public async Task Create(Servico servicos)
        {
             await _servicosRepository.Create(servicos);
        }

        public async Task Delete(int id)
        {
            await _servicosRepository.Delete(id);
        }

        public async Task<Servico?> Get(int id)
        {
            return await (_servicosRepository.Get(id));
        }

        public async Task<IEnumerable<Servico>> GetServicoByCliente(int id)
        {
            return await _servicosRepository.GetServicoByCliente(id);
        }

        public async Task<List<Servico>> List()
        {
            return await _servicosRepository.List();
        }

        public async Task Update(int id, Servico servicos)
        {
            await _servicosRepository.Update(id, servicos);
        }
    }
}
