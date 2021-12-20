using AgenciaComBack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgenciaComBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Destino()
        {
            return View();
        }
        public IActionResult Promocoes()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

    }
}
