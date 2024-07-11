using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;
using Petshop.src.Contracts.Service;

namespace Petshop.src.Service
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimalService(IAnimalRepository animalRepository) 
        {
            _animalRepository = animalRepository;
        }
        public async Task Create(Animal animal)
        {
            await _animalRepository.Create(animal);
        }

        public async Task Delete(int id)
        {
            await _animalRepository.Delete(id);
        }

        public async Task<Animal?> Get(int id)
        {
           return await _animalRepository.Get(id);        
        }

        public async Task<IEnumerable<Animal>> GetAnimalByCliente(int id)
        {
            return await _animalRepository.GetAnimalByCliente(id);
        }

        public async Task<List<Animal>> List()
        {
           return await _animalRepository.List();
        }

        public async Task Update(int id, Animal animal)
        {
            await _animalRepository.Update(id, animal);
        }
    }
}
