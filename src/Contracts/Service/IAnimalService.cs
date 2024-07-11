using Petshop.Model.Data;

namespace Petshop.src.Contracts.Service
{
    public interface IAnimalService
    {
        Task Create(Animal animais);
        Task Update(int id, Animal animais);
        Task Delete(int id);
        Task <Animal?> Get(int id);
        Task<List<Animal>> List();
        Task<IEnumerable<Animal>> GetAnimalByCliente(int id);
    }
}

