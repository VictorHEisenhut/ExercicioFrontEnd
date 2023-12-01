using AgendaMVC.Data;
using AgendaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AgendaMVC.Controllers
{
    public class CompromissoController : Controller
    {
        public IActionResult Index()
        {
            return View(Db.compromissos);
        }

        [HttpGet]
        public IActionResult Create()
        {

            List<SelectListItem> Contatos = new();
            Contatos = Db.contatos.Select(c => new SelectListItem() { Text = c.Nome, Value = c.Id.ToString() }).ToList();
            ViewBag.Contatos = Contatos;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Compromisso compromisso)
        {
            compromisso.Id = Db.compromissos.Count + 1;
            compromisso.Contato = Db.contatos.FirstOrDefault(id => id.Id == compromisso.Id);
            Db.compromissos.Add(compromisso);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            Compromisso compromisso = Db.compromissos.FirstOrDefault(c => c.Id == id);
            return View(compromisso);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            List<SelectListItem> Contatos = new();
            Contatos = Db.contatos.Select(c => new SelectListItem() { Text = c.Nome, Value = c.Id.ToString() }).ToList();
            ViewBag.Contatos = Contatos;

            Compromisso compromisso = Db.compromissos.FirstOrDefault(c => c.Id == id);
            return View(compromisso);
        }

        [HttpPost]
        public IActionResult Edit(Compromisso compromisso)
        {
            Compromisso compromissoNovo = Db.compromissos.FirstOrDefault(c => c.Id == compromisso.Id);
            compromissoNovo.Descricao = compromisso.Descricao;
            compromissoNovo.Data = compromisso.Data;
            Contato ctt = Db.contatos.FirstOrDefault(c => c.Id == compromisso.Contato.Id);
            compromissoNovo.Contato = ctt;
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            Compromisso compromisso = Db.compromissos.FirstOrDefault(c => c.Id == id);

            return View(compromisso);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(Compromisso compromisso)
        {
            var comp = Db.compromissos.FirstOrDefault(c => c.Id == compromisso.Id);

            if (comp != null)
            {
                Db.compromissos.Remove(comp);
            }

            return RedirectToAction("Index");
        }

    }
}
