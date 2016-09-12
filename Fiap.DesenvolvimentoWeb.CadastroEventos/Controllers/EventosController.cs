﻿using Fiap.DesenvolvimentoWeb.CadastroEventos.DAL;
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
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(EventosDb.ListarEventos());
        }
    }
}