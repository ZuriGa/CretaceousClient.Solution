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

  public IActionResult Details(int id)
  {
    Animal animal = Animal.GetDetails(id);
    return View(animal);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Animal animal)
  {
    Animal.Post(animal);
    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    Animal animal = Animal.GetDetails(id);
    return View(animal);
  }

  [HttpPost]
  public ActionResult Edit(Animal animal)
  {
    Animal.Put(animal);
    return RedirectToAction("Details", new { id = animal.AnimalId});
  }
}