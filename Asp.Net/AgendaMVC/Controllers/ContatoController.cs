using AgendaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaMVC.Controllers
{
    public class ContatoController : Controller
    {
        private static List<Contato> contatos = new();
        public IActionResult Index()
        {
            //contatos.Add(new Contato
            //{
            //    Id = 1,
            //    Nome = "Jamal",
            //    Email = "jamal@gmail.com",
            //    Fone = "47992750273"
            //});
            return View(contatos); 
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            contato.Id = contatos.Count + 1;
            contatos.Add(contato);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Contato ctt = contatos.FirstOrDefault(contato => contato.Id == id);
            return View(ctt);
        }

        [HttpPost]
        public IActionResult Edit(Contato ctt)
        {
            Contato contato = contatos.FirstOrDefault(contato => contato.Id == ctt.Id);
            contato.Nome = ctt.Nome;
            contato.Email = ctt.Email;
            contato.Fone = ctt.Fone;
            
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            Contato contato = contatos.FirstOrDefault(contato => contato.Id == id);
            return View(contato);
        }

        public IActionResult Delete(int? id)
        {
            Contato contato = contatos.FirstOrDefault(contato => contato.Id == id);

            return View(contato);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            Contato contato = contatos.FirstOrDefault(contato => contato.Id == id);

            if (contato != null)
            {
                contatos.Remove(contato);
            }
            return RedirectToAction("Index");
        }
    }
}
