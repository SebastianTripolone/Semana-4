using Microsoft.AspNetCore.Mvc;
using Semana4.Models;
using System.Diagnostics;

namespace Semana4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}