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
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            /*var cliente = new Destino();

            cliente.pais_destino = "Bélgica";
            cliente.cidade_destino = "Bruxelas";
            cliente.preco_destino = 1200;

            dbcontext.Add(destino);
            dbcontext.SaveChanges();*/

            ViewData["destinos"] = dbcontext.Destinos.Where(p => p.Id > 0).ToList();
            return View();
        }

        [HttpPost]
        [Route("Listar")]
        public IActionResult Incluir(Destino destino)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(destino);
            dbcontext.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
