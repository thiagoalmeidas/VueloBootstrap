using System;
using Microsoft.AspNetCore.Mvc;
using VueloBootstrap.Models;
using VueloBootstrap.Data;
using System.Linq;

namespace VueloBootstrap.Controllers
{
    [Route("Origem")]
    public class OrigemController : Controller
    {
        [HttpGet]
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            /*var origem = new Origem();

            cliente.pais_origem = "Brasil";
            cliente.cidade_origem = "Rio de Janeiro";
            cliente.preco_origem = 300;

            dbcontext.Add(origem);
            dbcontext.SaveChanges();*/

            ViewData["origens"] = dbcontext.Origens.Where(p => p.Id > 0).ToList();
            return View();
        }

        [HttpPost]
        [Route("Listar")]
        public IActionResult Incluir(Origem origem)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(origem);
            dbcontext.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
