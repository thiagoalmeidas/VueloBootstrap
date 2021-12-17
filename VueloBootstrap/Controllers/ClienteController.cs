using System;
using Microsoft.AspNetCore.Mvc;
using VueloBootstrap.Models;
using VueloBootstrap.Data;
using System.Linq;

namespace VueloBootstrap.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
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
        public IActionResult Index(Cliente cliente)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(cliente);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Cliente cliente)
        {
            var dbcontext = new Contexto();

            var clienteDelete = dbcontext.Clientes.Find(cliente.Id);
            dbcontext.Remove(clienteDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Cliente novosDadosCliente)
        {
            var dbcontext = new Contexto();

            var antigosDadosCliente = dbcontext.Clientes.Find(novosDadosCliente.Id);

            antigosDadosCliente.Nome = novosDadosCliente.Nome;
            antigosDadosCliente.Email = novosDadosCliente.Email;
            antigosDadosCliente.Telefone = novosDadosCliente.Telefone;
            antigosDadosCliente.Endereco = novosDadosCliente.Endereco;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}