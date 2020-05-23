using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using at02.Models;

namespace at02.Controllers
{
    public class PacoteController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;
            PacoteRepository pacotes = new PacoteRepository();
            List<Pacote> lista = pacotes.Lista();
            
            return View(lista);
        }

        public IActionResult Cadastra()
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastra(Pacote p)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;

            if(ModelState.IsValid)
            {
                PacoteRepository novoPacote = new PacoteRepository();
                novoPacote.Cadastra(p,Dados.usuario);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Route("pacote/atualiza/{id}")]
        public IActionResult Atualiza(int id)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;
            PacoteRepository pacote = new PacoteRepository();
            ViewBag.pacote = pacote.Lista(id);
            return View(ViewBag.pacote);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("pacote/atualiza/{id}")]
        public IActionResult Atualiza(int id, Pacote p)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;

            p.id = id;

            if(ModelState.IsValid)
            {
                PacoteRepository pacote = new PacoteRepository();
                pacote.Atualiza(p,Dados.usuario);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Route("pacote/apaga/{id}")]
        public IActionResult Apaga(int id)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;

            PacoteRepository pacote = new PacoteRepository();
            ViewBag.pacote = pacote.Lista(id);
            return View(ViewBag.pacote);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("pacote/apaga/{id}")]
        public IActionResult ConfirmaApaga(int id)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;

            PacoteRepository pacote = new PacoteRepository();
            if(ModelState.IsValid)
            {
                pacote.Apaga(id);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}
