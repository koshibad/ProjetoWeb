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

        internal static void IncluirConvidado(TBConvidados convidado)
        {
            using (var ent = new DBEVENTOSEntities())
            {
                ent.TBConvidados.Add(convidado);
                ent.SaveChanges();
            }
        }

        internal static List<TBConvidados> ListarConvidados(int? idEvento)
        {
            using (var ent = new DBEVENTOSEntities())
            {
                if (idEvento == null)
                    return ent.TBConvidados.ToList<TBConvidados>();

                return ent.TBConvidados.Where(x => x.IDEvento == (int)idEvento).ToList<TBConvidados>();
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

        public static void ExcluirEvento(TBEventos evento)
        {
            using (var ent = new DBEVENTOSEntities())
            {
                ent.Entry<TBEventos>(evento).State = System.Data.Entity.EntityState.Deleted;
                ent.SaveChanges();
            }
        }
    }
}