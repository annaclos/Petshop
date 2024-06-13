using Petshop.Model.Data;

namespace Petshop.src.Contracts.Repository
{
    public interface IClientesRepository
    {
        void Create(Clientes clientes);
        void Update(int id, Clientes clientes);
        bool Delete(int id);
        Clientes Get(int id);
        List<Clientes> List();
    }
}
