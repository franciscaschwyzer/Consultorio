using Microsoft.AspNetCore.Mvc;

namespace consultorio.Controllers
{
    public class ConsultaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
