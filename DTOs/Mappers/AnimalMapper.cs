using Petshop.Model.Data;
using System.Reflection.Metadata.Ecma335;

namespace Petshop.DTOs.Mappers;

public static class AnimalMapper
{
    public static AnimalDTO ToAnimalDTO(Animal animal)
    {
        return new AnimalDTO
        {
            Id = animal.Id,
            Raca = animal.Raca,
            Especie = animal.Especie,
            ClienteId = animal.ClienteId
        };
    }
}
