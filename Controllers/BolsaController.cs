using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Operación_en_bolsa.Models;

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
            Usuario u=new Usuario();
            Console.WriteLine("Controlador ejecutado");
            return View(u);

        }
        [HttpPost]
        public IActionResult Registro(Usuario user)
        {
            
            if (user.InstrumentosSeleccionados == null || !user.InstrumentosSeleccionados.Any())
            {   
                ModelState.AddModelError("InstrumentosSeleccionados", "Por favor seleccione al menos una opción");
                Index();
            }else{
                Console.WriteLine("Controlador ejecutado 2");
                List<string>select=user.InstrumentosSeleccionados;
                ViewData["usuario"]=user;
                ViewData["lista"]=select;
                Usuario u=new Usuario();
                return View("Index",u);
            }
            Usuario us=new Usuario();
            return View("Index",us);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}