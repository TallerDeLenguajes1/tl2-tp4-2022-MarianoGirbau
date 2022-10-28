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

        private static readonly List<Cadete> cadetes = new();

        private static int idCadetes = 0;

        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(cadetes);
        }

        [HttpGet]
        public IActionResult RegistroCadete()
        {   
            return View();
        }

        public void RegistroCadeteExito(Cadete cadete)
        {
            cadete.ID = ++idCadetes;
            cadetes.Add(cadete);
            Response.Redirect("/Cadete");
        }

        [HttpGet]
        public void BajaCadete(Cadete cadete)
        {   
            cadetes.RemoveAll(x => x.ID == idCadetes);
            Response.Redirect("/Cadete");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}