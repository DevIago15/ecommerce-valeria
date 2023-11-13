using Ecommerce.Models;
using Ecommerce.Models.Data;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult IndexProd()
        {
            ProdutoData data = new ProdutoData();
            return View(data.Read());

        }

        public ActionResult Create()
        {
            CategoriaData data = new CategoriaData();
            ViewBag.Categorias = data.Read();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produto prod)
        {
            if (prod.NomeProd != null)
            {
                ProdutoData data = new ProdutoData();
                data.Create(prod);
            }

            return RedirectToAction("IndexProd");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            CategoriaData dataCat = new CategoriaData();
            ViewBag.Categorias = dataCat.Read();

            ProdutoData data = new ProdutoData();
            return View(data.Read(id));
        }

        [HttpPost]
        public ActionResult Update(int id, Produto prod)
        {
            prod.IdProduto = id;

            if (prod.NomeProd == null)
                return View(prod);

            ProdutoData data = new ProdutoData();
            data.Update(prod);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Delete(int id)
        {
            ProdutoData data = new ProdutoData();
            data.Delete(id);

            return RedirectToAction("Index", "Home");
        }
    }
}
