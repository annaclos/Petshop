using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;
using Petshop.src.Contracts.Service;

namespace Petshop.src.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Create(Cliente clientes)
        {
            await _clienteRepository.Create(clientes);
        }

        public async Task Delete(int id)
        {
            await _clienteRepository.Delete(id);
        }

        public async Task<Cliente?> Get(int id)
        {
            return await _clienteRepository.Get(id);
        }

        public async Task Update(int id, Cliente clientes)
        {
            await _clienteRepository.Update(id, clientes);
        }
        public async Task<List<Cliente>> List()
        {
           return await _clienteRepository.List();
        }
    }
}
