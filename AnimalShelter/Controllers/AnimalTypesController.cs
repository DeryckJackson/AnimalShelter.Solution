using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class AnimalTypesController : Controller
  {
    private readonly AnimalShelterContext _db;
    public AnimalTypesController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<AnimalType> model = _db.AnimalTypes.ToList();
      return View(model);
    }
  }
}