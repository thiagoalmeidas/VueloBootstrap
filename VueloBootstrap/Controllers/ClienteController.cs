using System;
using Microsoft.AspNetCore.Mvc;
using VueloBootstrap.Models;
using VueloBootstrap.Data;
using System.Linq;

namespace VueloBootstrap.Controllers
{
    [Route("Cliente")]
    public class ClienteController : Controller
    {
        [HttpGet]
        [Route("Listar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            /*var cliente = new Cliente();

            cliente.Nome = "Thiago";
            cliente.Email = "Thiago@hotmail.com";
            cliente.Telefone = "11987583522";
            cliente.Endereco = "Rua Pavao 25";

            dbcontext.Add(cliente);
            dbcontext.SaveChanges();*/

            ViewData["clientes"] = dbcontext.Clientes.Where(p => p.Id > 0).ToList();
            return View();
        }

        [HttpPost]
        [Route("Listar")]
        public IActionResult Incluir(Cliente cliente)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(cliente);
            dbcontext.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
