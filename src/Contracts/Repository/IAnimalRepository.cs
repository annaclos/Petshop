using Petshop.Model.Data;

namespace Petshop.src.Contracts.Repository
{
    public interface IAnimalRepository
    {
        void Create(Animal animal);
        void Update(int id, Animal animal);
        bool Delete(int id);
        Animal Get(int id);
        List<Animal> List();
    }
}
