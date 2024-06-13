using Petshop.Model.Data;

namespace Petshop.src.Contracts.Service
{
    public interface IAnimalService
    {
        void Create(Animal animais);
        void Update(int id, Animal animais);
        bool Delete(int id);
        Animal Get(int id);
        List<Animal> List();
    }
}

