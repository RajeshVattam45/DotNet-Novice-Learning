using Microsoft.AspNetCore.Mvc;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    [Route("Fruits")]
    public class FruitController : Controller
    {
        public object Index()
        {
            var fruits = new List<Fruit>
            {
                new Fruit { Id = 1, Name = "Apple", Color = "Red" },
                new Fruit { Id = 2, Name = "Banana", Color = "Yellow" },
                new Fruit { Id = 3, Name = "Orange", Color = "Orange" },
                new Fruit { Id = 4, Name = "Grapes", Color = "Green" },
                new Fruit { Id = 5, Name = "Blueberry", Color = "Blue" }
            };

            return View(fruits);
        }
    }
}
