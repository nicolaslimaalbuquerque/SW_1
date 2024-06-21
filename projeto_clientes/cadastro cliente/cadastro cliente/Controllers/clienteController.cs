using Microsoft.AspNetCore.Mvc;

namespace cadastro_cliente.Controllers
{
    public class clienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
