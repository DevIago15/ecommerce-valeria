using EcommerceCCO2023.Models;
using EcommerceCCO2023.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EcommerceCCO2023.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult IndexCliente()
        {
            ClienteData data = new ClienteData();
            return View(data.Read());

        }

        [HttpPost]
        public IActionResult IndexLogin(Cliente cliente)
        {
            if(cliente.Email != null && cliente.Senha != null)
            {
                Cliente cli = new Cliente();
                ClienteData cliData = new ClienteData();
                     cli = cliData.Read(cliente.Email);
                if(cli.Email == cliente.Email && cli.Senha == cliente.Senha)
                {
                    return RedirectToAction("Index", "Home");   
                }
            }
            return View();
        }
        public IActionResult Create()
        {
            ClienteData data = new ClienteData();
            ViewBag.Cliente = data.Read();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (cliente.Nome != null)
            {
                ClienteData data = new ClienteData();
                data.Create(cliente);
            }

            return RedirectToAction("IndexCliente");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ClienteData data = new ClienteData();
            return View(data.Read(id));
        }

        [HttpPost]
        public IActionResult Update(int id, Cliente cliente)
        {
            cliente.IdCliente = id;

            if (cliente.Nome == null)
                return View(cliente);

            ClienteData data = new ClienteData();
            data.Update(cliente);

            return RedirectToAction("IndexCliente");
        }

        public IActionResult Delete(int id)
        {
            ClienteData data = new ClienteData();
            data.Delete(id);

            return RedirectToAction("IndexCliente");
        }
    }
}
