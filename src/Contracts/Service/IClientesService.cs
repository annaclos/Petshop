using Petshop.Model.Data;

namespace Petshop.src.Contracts.Service
{
    public interface IClientesService
    {
        void Create(Clientes clientes);
        void Update(int id, Clientes clientes);
        bool Delete(int id);
        Clientes Get(int id);
        List<Clientes> List();
    }
}
