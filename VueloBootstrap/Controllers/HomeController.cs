using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VueloBootstrap.Models;

namespace VueloBootstrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private static IList<Origem> origens = new List<Origem>()
        {
            new Origem()
            {
                Id = 1,
                pais_origem = "Brasil",
                cidade_origem = "São Paulo",
                preco_origem = 300
            },
            new Origem()
            {
                Id = 2,
                pais_origem = "Brasil",
                cidade_origem = "Rio de Janeiro",
                preco_origem = 200
            },
              new Origem()
            {
                Id = 3,
                pais_origem = "Brasil",
                cidade_origem = "Brasília",
                preco_origem = 400
            }

        };

        private static IList<Destino> dest = new List<Destino>()
        {
            new Destino()
            {
                Id = 1,
                pais_destino = "França",
                cidade_destino = "Páris",
                preco_destino = 1200
            },
            new Destino()
            {
                Id = 2,
                pais_destino = "Alemanha",
                cidade_destino = "Berlim",
                preco_destino = 1400
            },
            new Destino()
            {
                Id = 3,
                pais_destino = "Espanha",
                cidade_destino = "Madri",
                preco_destino = 800
            },
            new Destino()
            {
                Id = 4,
                pais_destino = "Bélgica",
                cidade_destino = "Bruxelas",
                preco_destino = 1300
            },
            new Destino()
            {
                Id = 5,
                pais_destino = "Dinamarca",
                cidade_destino = "Copenhague",
                preco_destino = 1800
            },

        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult destinos()
        {
            return View(origens);
        }

        public IActionResult promocoes()
        {
            return View();
        }

        public IActionResult contato()
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
