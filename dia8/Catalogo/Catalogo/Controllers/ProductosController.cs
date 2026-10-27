using Microsoft.AspNetCore.Mvc;
using Catalogo.Models;
namespace Catalogo.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index() {
            List<Producto> productos = new List<Producto> {
                new Producto{Codigo = "123",Nombre = "Papa", Categoria = "Frutas y Verduras",PrecioVenta = 6500,Stock = 100 }

            };
        
            return View(productos);
        }

    }
}
