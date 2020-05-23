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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;
            PacoteRepository pacotes = new PacoteRepository();
            List<Pacote> lista = pacotes.Lista();
            
            return View(lista);
        }

        public IActionResult Login()
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;
            if(!Dados.logado)
                return View();
            else
                return RedirectToAction("index","usuario");
                
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login l)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;
            if(ModelState.IsValid)
            {
                LoginRepository login = new LoginRepository();
                login.Login(l);
                if (Dados.logado) return RedirectToAction("index","usuario");
            }
            return View();
        }

        public IActionResult Logoff()
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;

            LoginRepository login = new LoginRepository();
            login.Logoff();

            return RedirectToAction("index");
                
        }

    }
}
