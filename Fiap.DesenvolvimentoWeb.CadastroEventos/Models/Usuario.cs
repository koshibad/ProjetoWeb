﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.DesenvolvimentoWeb.CadastroEventos.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [DataType(DataType.Password)]
        public string Confirma { get; set; }
    }
}