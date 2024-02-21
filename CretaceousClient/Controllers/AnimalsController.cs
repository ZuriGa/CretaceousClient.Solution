using Microsoft.AspNetCore.Mvc;
using CretaceousClient.Models;

namespace CretaceousClient.Controllers;

public class AnimalsController : Controller
{
  public IActionResult Index()
  {
    List<Animal> animals = Animal.GetAnimals();
    return View(animals);
  }
}