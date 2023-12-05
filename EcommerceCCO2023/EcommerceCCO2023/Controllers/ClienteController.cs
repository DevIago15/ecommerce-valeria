using EcommerceCCO2023.Models;
using EcommerceCCO2023.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCCO2023.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult IndexCliente()
        {
            ClienteData data = new ClienteData();
            return View(data.Read());

        }

        public IActionResult Create()
        {
            ClienteData data = new ClienteData();
            ViewBag.Cliente = data.Read();
            return View();
        }
        // Método para exibir a tela de login
        public IActionResult IndexLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string senha)
        {
            ClienteData clienteData = new ClienteData();
            Cliente cliente = clienteData.Authenticate(email, senha);

            if (cliente != null)
            {
                // Autenticação bem-sucedida
                return RedirectToAction("Index", "Home"); // Redireciona para a página inicial
            }
            else
            {
                // Autenticação falhou
                TempData["MensagemErro"] = "Credenciais inválidas. Registre-se Agora";
                return View("IndexCadastro"); // Redireciona para o cadastro
            }
        }


        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (cliente.Nome != null)
            {
                ClienteData data = new ClienteData();
                data.Create(cliente);
            }

            return RedirectToAction("IndexLogin", "Cliente");
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
