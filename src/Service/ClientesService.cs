using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;
using Petshop.src.Contracts.Service;

namespace Petshop.src.Service
{
    public class ClientesService : Contracts.Service.IClientesService
    {
        private readonly Contracts.Repository.IClientesRepository _clienteRepository;
        public ClientesService (Contracts.Repository.IClientesRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Create(Clientes clientes)
        {
            _clienteRepository.Create(clientes);
        }

        public bool Delete(int id)
        {
            return _clienteRepository.Delete(id);
        }

        public Clientes Get(int id)
        {
            return _clienteRepository.Get(id);
        }

        public List<Clientes> List()
        {
            return _clienteRepository.List();
        }

        public void Update(int id, Clientes clientes)
        {
            _clienteRepository.Update(id, clientes);
        }
    }
}
