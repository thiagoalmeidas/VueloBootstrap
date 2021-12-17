using System;
using Microsoft.AspNetCore.Mvc;
using VueloBootstrap.Models;
using VueloBootstrap.Data;
using System.Linq;

namespace VueloBootstrap.Controllers
{
    public class OrigemController : Controller
    {
        [HttpGet]
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
        public IActionResult Index(Origem origem)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(origem);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Origem origem)
        {
            var dbcontext = new Contexto();

            var origemDelete = dbcontext.Origens.Find(origem.Id);
            dbcontext.Remove(origemDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Origem novosDadosOrigem)
        {
            var dbcontext = new Contexto();

            var antigosDadosOrigem = dbcontext.Origens.Find(novosDadosOrigem.Id);

            antigosDadosOrigem.pais_origem = novosDadosOrigem.pais_origem;
            antigosDadosOrigem.cidade_origem = novosDadosOrigem.cidade_origem;
            antigosDadosOrigem.preco_origem = novosDadosOrigem.preco_origem;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
