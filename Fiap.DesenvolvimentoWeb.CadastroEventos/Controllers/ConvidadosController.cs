using Fiap.DesenvolvimentoWeb.CadastroEventos.DAL;
using Fiap.DesenvolvimentoWeb.CadastroEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.DesenvolvimentoWeb.CadastroEventos.Controllers
{
    public class ConvidadosController : Controller
    {
        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.ListaEventos = new SelectList(EventosDb.ListarEventos(), "IDEvento", "Descricao");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(TBConvidados conv)
        {
            if (ModelState.IsValid)
            {
                EventosDb.IncluirConvidado(conv);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ListaEventos = new SelectList(EventosDb.ListarEventos(), "IDEvento", "Descricao");
            return View();
        }

        [HttpGet]
        public ActionResult ListarConvidados(int? idEvento)
        {
            ViewBag.TodosEventos = new SelectList(EventosDb.ListarEventos(), "IDEvento", "Descricao");
            return View(EventosDb.ListarConvidados(idEvento));
        }
    }
}