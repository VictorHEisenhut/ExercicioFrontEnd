using AgendaMVC.Dao;
using AgendaMVC.Models;
using AgendaMVC.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AgendaMVC.Controllers
{
    public class CompromissoController : Controller
    {
        private CompromissoDao dao = new(Connect.Conectar());
        public IActionResult Index()
        {
            return View(dao.Consultar());
        }

        [HttpGet]
        public IActionResult Create()
        {

            List<SelectListItem> Contatos = new();
            Contatos = new ContatoDao(Connect.Conectar()).Consultar().Select(c => new SelectListItem() { Text = c.Nome, Value = c.Id.ToString() }).ToList();
            ViewBag.Contatos = Contatos;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Compromisso compromisso)
        {
            //compromisso.Id = Db.compromissos.Count + 1;
            //compromisso.Contato = Db.contatos.FirstOrDefault(id => id.Id == compromisso.Id);
            //Db.compromissos.Add(compromisso);
            dao.Salvar(compromisso);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Compromisso compromisso = dao.Consultar(id);
            return View(compromisso);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<SelectListItem> Contatos = new();
            Contatos = new ContatoDao(Connect.Conectar()).Consultar().Select(c => new SelectListItem() { Text = c.Nome, Value = c.Id.ToString() }).ToList();
            ViewBag.Contatos = Contatos;

            Compromisso compromisso = dao.Consultar(id);
            return View(compromisso);
        }

        [HttpPost]
        public IActionResult Edit(Compromisso compromisso)
        {
            Compromisso compromissoNovo = dao.Consultar(compromisso.Id);
            compromissoNovo.Descricao = compromisso.Descricao;
            compromissoNovo.Data = compromisso.Data;
            Contato ctt = new ContatoDao(Connect.Conectar()).Consultar(compromisso.Contato.Id);
            compromissoNovo.Contato = ctt;
            dao.Alterar(compromissoNovo);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Compromisso compromisso = dao.Consultar(id);

            return View(compromisso);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(Compromisso compromisso)
        {
            var comp = dao.Consultar(compromisso.Id);

            if (comp != null)
            {
                dao.Deletar(compromisso);
            }

            return RedirectToAction("Index");
        }

    }
}
