using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;
using Petshop.src.Contracts.Service;

namespace Petshop.src.Service
{
    public class AnimaisService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimaisService(IAnimalRepository animalRepository) 
        {
            _animalRepository = animalRepository;
        }
        public void Create(Animal animal)
        {
            _animalRepository.Create(animal);
        }

        public bool Delete(int id)
        {
            return _animalRepository.Delete(id);
        }

        public Animal Get(int id)
        {
            return _animalRepository.Get(id);        
        }

        public List<Animal> List()
        {
            return _animalRepository.List();
        }

        public void Update(int id, Animal animal)
        {
           _animalRepository.Update(id, animal);
        }
    }
}
