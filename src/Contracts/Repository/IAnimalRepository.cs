using Petshop.Model.Data;

namespace Petshop.src.Contracts.Repository
{
    public interface IAnimalRepository
    {
        Task Create(Animal animal);
        Task Update(int id, Animal animal);
        Task Delete(int id);
        Task<Animal?> Get(int id);
        Task<List<Animal>> List();
        Task<IEnumerable<Animal>> GetAnimalByCliente(int id);
    }
}
