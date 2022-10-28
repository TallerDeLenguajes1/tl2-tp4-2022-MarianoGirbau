using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TP4.Controllers
{
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;

        private readonly List<Cadete> cadetes = new();

        private static int cantCadetes = 1;

        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
        }

        /*public IActionResult Index()
        {
            return View();
        }*/

        [HttpGet]
        public IActionResult RegistroCadete()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult AltaCadete(string nombre, string direccion, string telefono)
        {   
            Cadete cadete= new Cadete(cantCadetes,nombre,direccion,telefono);
            cadetes.Add(cadete);
            cantCadetes++;
            return View("ListaCadete", cadetes);
        }

        [HttpPost]
        public IActionResult BajaCadete(Cadete cadete)
        {   
            cadetes.Remove(cadete);
            return View(cadete);
        }

        [HttpPost]
        public IActionResult ListaCadete(List<Cadete> cadetes)
        {   
            return View(cadetes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}