using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;

namespace Petshop.src.Repository
{
    public class AnimaisRepository : IAnimalRepository
    {
        private List<Animal> animais = new List<Animal>
        {
            new Animal
            {
                Id = 1,
                Raca = "chiwawa",
                Especie = "gato"
            }
        };
        public void Create(Animal animal)
        {
            animais.Add(animal);
        }

        public bool Delete(int id)
        {
            var animalDB = animais.FirstOrDefault(x=>x.Id == id);
            animais.Remove(animalDB);
            return true;
        }

        public Animal Get(int id)
        {
            return animais.FirstOrDefault(x => x.Id == id)!;
        }
        public List<Animal> List()
        {
            return animais;
        }

        public void Update(int id, Animal animal)
        {
            var animalDB = animais.FirstOrDefault(x=>x.Id == id)!;
            animalDB.Raca = animal.Raca;
            animalDB.Especie = animal.Especie;
        }
    }
}
