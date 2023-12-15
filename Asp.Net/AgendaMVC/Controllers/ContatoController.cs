using AgendaMVC.Dao;
using AgendaMVC.Models;
using AgendaMVC.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace AgendaMVC.Controllers
{
    public class ContatoController : Controller
    {
        private ContatoDao dao = new(Connect.Conectar());
        public IActionResult Index(string sortOrder)
        {
            ViewBag.nomeSortParam = String.IsNullOrEmpty(sortOrder) ? "nome_desc" : "";

            var contatos = from c in dao.Consultar() select c;

            switch (sortOrder)
            {
                case "nome_desc":
                    contatos = contatos.OrderByDescending(c => c.Nome);
                    break;
                default:
                    contatos = contatos.OrderBy(c => c.Nome);
                    break;
            }

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
            //contato.Id = Db.contatos.Count + 1;
            //Db.contatos.Add(contato);
            //ContatoDao dao = new(Connect.Conectar());

            dao.Salvar(contato);
            return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Contato ctt = dao.Consultar(id);
            return View(ctt);
        }

        [HttpPost]
        public IActionResult Edit(Contato ctt)
        {
            Contato contato = dao.Consultar(ctt.Id);
            contato.Nome = ctt.Nome;
            contato.Email = ctt.Email;
            contato.Fone = ctt.Fone;
            dao.Alterar(contato);
            
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Contato contato = dao.Consultar(id);
            return View(contato);
        }

        public IActionResult Delete(int id)
        {
            Contato contato = dao.Consultar(id);

            return View(contato);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            Contato contato = dao.Consultar(id);

            if (contato != null)
            {
                dao.Deletar(contato);
            }
            return RedirectToAction("Index");
        }
    }
}
