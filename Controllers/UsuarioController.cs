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
    public class UsuarioController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;
            
            UsuarioRepository usuarios = new UsuarioRepository();
            List<Usuario> lista = usuarios.Lista();
            
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
        public IActionResult Cadastra(Usuario u)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;

            if(ModelState.IsValid)
            {
                UsuarioRepository novoUsuario = new UsuarioRepository();
                novoUsuario.Cadastra(u);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Route("usuario/atualiza/{id}")]
        public IActionResult Atualiza(int id)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;

            UsuarioRepository usuario = new UsuarioRepository();
            ViewBag.usuario = usuario.Lista(id);
            return View(ViewBag.usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("usuario/atualiza/{id}")]
        public IActionResult Atualiza(int id, Usuario u)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;

            u.id = id;
            if(ModelState.IsValid)
            {
                UsuarioRepository usuario = new UsuarioRepository();
                usuario.Atualiza(u);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Route("usuario/apaga/{id}")]
        public IActionResult Apaga(int id)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;

            UsuarioRepository usuario = new UsuarioRepository();
            ViewBag.usuario = usuario.Lista(id);
            return View(ViewBag.usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("usuario/apaga/{id}")]
        public IActionResult ConfirmaApaga(int id)
        {
            ViewBag.logado = Dados.logado;
            ViewBag.admin = Dados.admin;

            UsuarioRepository usuario = new UsuarioRepository();

            if(ModelState.IsValid)
            {
                usuario.Apaga(id);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}
