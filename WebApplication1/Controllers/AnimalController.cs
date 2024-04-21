using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;


[Route("api/animals")]
[ApiController]
public class AnimalController : ControllerBase
{

    private static readonly List<Animal> _animals = new()
    {
        new Animal {IdAnimal = 1, Name = "Puszek", Category = "pies", Weight = 15, Colour = "black"},
        new Animal {IdAnimal = 2, Name = "Chmurka", Category = "kot", Weight = 7, Colour = "white"},
        new Animal {IdAnimal = 3, Name = "Mini", Category = "pies", Weight = 12, Colour = "brown"},
    };


    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animals.FirstOrDefault(an => an.IdAnimal == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        return Ok(animal);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult EditAnimal(int id, Animal animal)
    {
        var animalToEdit = _animals.FirstOrDefault(an => an.IdAnimal == id);

        if (animalToEdit == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        _animals.Remove(animalToEdit);
        _animals.Add(animal);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToDelete = _animals.FirstOrDefault(an => an.IdAnimal == id);
        if (animalToDelete == null)
        {
            return NoContent();
        }

        _animals.Remove(animalToDelete);
        return NoContent();
    }
}
