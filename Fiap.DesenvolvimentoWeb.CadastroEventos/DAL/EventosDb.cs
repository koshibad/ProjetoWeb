using Fiap.DesenvolvimentoWeb.CadastroEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.DesenvolvimentoWeb.CadastroEventos.DAL
{
    public class EventosDb
    {
        public static void IncluirEvento(TBEventos evento)
        {
            using (var ent = new DBEVENTOSEntities())
            {
                ent.TBEventos.Add(evento);
                ent.SaveChanges();
            }
        }

        public static List<TBEventos> ListarEventos()
        {
            using (var ent = new DBEVENTOSEntities())
            {
                return ent.TBEventos.ToList<TBEventos>();
            }
        }

        public static TBEventos BuscarEvento(int id)
        {
            using (var ent = new DBEVENTOSEntities())
            {
                return ent.TBEventos.FirstOrDefault(x => x.IDEvento == id);
            }
        }

        public static void AlterarEvento(TBEventos evento)
        {
            using (var ent = new DBEVENTOSEntities())
            {
                ent.Entry<TBEventos>(evento).State = System.Data.Entity.EntityState.Modified;
                ent.SaveChanges();
            }
        }
    }
}