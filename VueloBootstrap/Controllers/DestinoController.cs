using System;
using Microsoft.AspNetCore.Mvc;
using VueloBootstrap.Models;
using VueloBootstrap.Data;
using System.Linq;

namespace VueloBootstrap.Controllers
{
    [Route("Destino")]
    public class DestinoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            /*var destino = new Destino();

            destino.pais_destino = "Bélgica";
            destino.cidade_destino = "Bruxelas";
            destino.preco_destino = 1200;

            dbcontext.Add(destino);
            dbcontext.SaveChanges();*/

            ViewData["destinos"] = dbcontext.Destinos.Where(p => p.Id > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Destino destino)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(destino);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Destino destino)
        {
            var dbcontext = new Contexto();

            var destinoDelete = dbcontext.Destinos.Find(destino.Id);
            dbcontext.Remove(destinoDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Destino novosDadosDestino)
        {
            var dbcontext = new Contexto();

            var antigosDadosDestino = dbcontext.Destinos.Find(novosDadosDestino.Id);

            antigosDadosDestino.pais_destino = novosDadosDestino.pais_destino;
            antigosDadosDestino.cidade_destino = novosDadosDestino.cidade_destino;
            antigosDadosDestino.preco_destino = novosDadosDestino.preco_destino;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
