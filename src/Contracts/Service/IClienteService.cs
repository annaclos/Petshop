using Petshop.Model.Data;

namespace Petshop.src.Contracts.Service
{
    public interface IClienteService
    {
        Task Create(Cliente clientes);
        Task Update(int id, Cliente clientes);
        Task Delete(int id);
        Task <Cliente?> Get(int id);
        Task<List<Cliente>> List();
    }
}
