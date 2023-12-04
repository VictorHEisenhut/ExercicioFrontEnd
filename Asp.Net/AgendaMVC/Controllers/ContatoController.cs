﻿using AgendaMVC.Dao;
using AgendaMVC.Data;
using AgendaMVC.Models;
using AgendaMVC.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace AgendaMVC.Controllers
{
    public class ContatoController : Controller
    {
        private ContatoDao dao = new(Connect.Conectar());
        public IActionResult Index()
        {
            //contatos.Add(new Contato
            //{
            //    Id = 1,
            //    Nome = "Jamal",
            //    Email = "jamal@gmail.com",
            //    Fone = "47992750273"
            //});
            return View(dao.Consultar()); 
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
