using AgendaMVC.Data;
using AgendaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            //contatos.Add(new Contato
            //{
            //    Id = 1,
            //    Nome = "Jamal",
            //    Email = "jamal@gmail.com",
            //    Fone = "47992750273"
            //});
            return View(Db.contatos); 
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            contato.Id = Db.contatos.Count + 1;
            Db.contatos.Add(contato);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Contato ctt = Db.contatos.FirstOrDefault(contato => contato.Id == id);
            return View(ctt);
        }

        [HttpPost]
        public IActionResult Edit(Contato ctt)
        {
            Contato contato = Db.contatos.FirstOrDefault(contato => contato.Id == ctt.Id);
            contato.Nome = ctt.Nome;
            contato.Email = ctt.Email;
            contato.Fone = ctt.Fone;
            
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            Contato contato = Db.contatos.FirstOrDefault(contato => contato.Id == id);
            return View(contato);
        }

        public IActionResult Delete(int? id)
        {
            Contato contato = Db.contatos.FirstOrDefault(contato => contato.Id == id);

            return View(contato);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            Contato contato = Db.contatos.FirstOrDefault(contato => contato.Id == id);

            if (contato != null)
            {
                Db.contatos.Remove(contato);
            }
            return RedirectToAction("Index");
        }
    }
}
