using EcommerceCCO2023.Models;
using EcommerceCCO2023.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCCO2023.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult IndexProd()
        {
            ProdutoData data = new ProdutoData();
                return View(data.Read());
           
        }

        public IActionResult Create()
        {
            CategoriaData data = new CategoriaData(); 
            ViewBag.Categorias = data.Read();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto prod)
        {
            if (prod.NomeProd != null)
            {
                ProdutoData data = new ProdutoData();
                data.Create(prod);
            }          

            return RedirectToAction("IndexProd");
        }

        [HttpGet]
        public IActionResult Update(int id)
        { 
            CategoriaData dataCat = new CategoriaData();           
            ViewBag.Categorias = dataCat.Read();

            ProdutoData data = new ProdutoData();
            return View(data.Read(id));
        }

        [HttpPost]
        public IActionResult Update(int id, Produto prod)
        {
            prod.IdProduto = id;

            if (prod.NomeProd == null)
                return View(prod);

            ProdutoData data = new ProdutoData();
                data.Update(prod);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            ProdutoData data = new ProdutoData();
                data.Delete(id);

            return RedirectToAction("Index", "Home");
        }
    }
}
