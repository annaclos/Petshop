using Petshop.Model.Data;

namespace Petshop.src.Contracts.Repository
{
    public interface IServicosRepository
    {
        void Create(Servicos servicos);
        void Update(int id, Servicos servicos);
        bool Delete(int id);
        Servicos Get(int id);
        List<Servicos> List();
    }
}
