using Fiap.DesenvolvimentoWeb.CadastroEventos.DAL;
using Fiap.DesenvolvimentoWeb.CadastroEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.DesenvolvimentoWeb.CadastroEventos.Controllers
{
    public class EventosController : Controller
    {
        // GET: Eventos
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(TBEventos evento)
        {
            if (ModelState.IsValid)
            {
                EventosDb.IncluirEvento(evento);
                return RedirectToAction("Listar");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(EventosDb.ListarEventos());
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
                return RedirectToAction("Index", "Home");

            return View(EventosDb.BuscarEvento((int)id));
        }

        [HttpPost]
        public ActionResult Editar(int? id, TBEventos evento)
        {
            if (ModelState.IsValid)
            {
                EventosDb.AlterarEvento(evento);
                return RedirectToAction("Listar");
            }

            return View(EventosDb.BuscarEvento((int)id));
        }

        [HttpGet]
        public ActionResult Excluir(int? id)
        {
            if (id == null)
                return RedirectToAction("Index", "Home");

            return View(EventosDb.BuscarEvento((int)id));
        }

        [HttpPost]
        public ActionResult Excluir(int? id, TBEventos evento)
        {
            if (id == null)
                return RedirectToAction("Index", "Home");

            evento.IDEvento = (int)id;
            EventosDb.ExcluirEvento(evento);
            return RedirectToAction("Listar");
        }
    }
}