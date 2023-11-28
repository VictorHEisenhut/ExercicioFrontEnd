using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class ContatoController : Controller
    {
        private List<Contato> contatos = new()
        {
            new Contato { Id = 1, Nome = "jamal", Email = "jamal@gmail.com" },
            new Contato { Id = 2, Nome = "kleber", Email = "kleber@gmail.com" },
            new Contato { Id = 3, Nome = "terance", Email = "terance@gmail.com" }
        };
        public IActionResult Index()
        {
            return View(contatos);
        }

        public IActionResult GetFirstContato()
        {
            return View(contatos.FirstOrDefault());
        }
    }
}
