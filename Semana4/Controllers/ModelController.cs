using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Semana4.Models;

namespace Semana4.Controllers
{
    public class ModelController : Controller
    {
        // GET: ModelController
        public async Task<IActionResult> Index()
        {
            var listMovies = new List<Modelo>();

            var movie1 = new Modelo
            {
                Genero = "Terror",
                Id = 1,
                Precio = 1,
                FechaRealizacion = DateTime.Now,
                Titulo = "La noche del terror"
            };
            listMovies.Add(movie1);

            var movie2 = new Modelo
            {
                Genero = "Terror",
                Id = 1,
                Precio = 1,
                FechaRealizacion = DateTime.Now,
                Titulo = "La noche del terror II"
            };
            listMovies.Add(movie2);

            return View(listMovies);

        }

        // GET: ModelController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Simulación de creación de un objeto (model)
            //Mas adelante vamos a ver como usar una base de datos
            var movie = new Modelo
            {
                Genero = "Terror",
                Id = 1,
                Precio = 1,
                FechaRealizacion = DateTime.Now,
                Titulo = "La noche del terror"
            };


            return View(movie);
        }

        // GET: ModelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ModelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ModelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
