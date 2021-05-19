using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using exercicio.Models;

namespace exercicio.Controllers
{
    public class QuestoesController : Controller
    {
        private readonly ILogger<QuestoesController> _logger;

        public QuestoesController(ILogger<QuestoesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Questoes q = new Questoes();

            List<int> lista = new List<int> { 10, 34, 44, 667, 789, 2, 5, 852, 22, 34, 78, 94, 9857, 0, 6 };

            int valor = q.ReconhecerDuplicadosLista(lista);

            ViewBag.minha_lista = lista;

            ViewBag.teste = (int)valor;

            return View();
        }

        [HttpGet]
        public IActionResult CheckPalindromo()
        {

            return View();

        }

        [HttpPost]
        public JsonResult CheckPalindromo(string palavra)
        {
                  Questoes model = new Questoes();
                  model.ReconhecerPalindrome(palavra);
                  return Json(model);


        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
