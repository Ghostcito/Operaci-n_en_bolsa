using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Operación_en_bolsa.Controllers
{
    public class BolsaController : Controller
    {
        private readonly ILogger<BolsaController> _logger;

        public BolsaController(ILogger<BolsaController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registro()
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}