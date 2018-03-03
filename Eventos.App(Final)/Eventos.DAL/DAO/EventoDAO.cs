using Eventos.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventos.DAL.DAO
{
    public class EventoDAO
    {
        public List<Evento> ObterTodos()
        {
            using (var database = new Database())
            {

                return database.Eventos.ToList();
            }
        }
        public void Inserir(Evento evento)
        {
            using (var database = new Database())
            {
                database.Eventos.Add(evento);
                database.SaveChanges();
            }

        }

        public Evento ObterPorId(int id)
        {
            using (var database = new Database())
            {
                return database.Eventos.Find(id);
            }
        }

        public void Deletar(int id)
        {
            using (var database = new Database())
            {
                var evento = ObterPorId(id);
                database.Eventos.Remove(evento);
                database.SaveChanges();
            }
        }

        public void Atualizar(Evento evento)
        {

            using (var database = new Database())
            {
                database.Eventos.Update(evento);
                database.SaveChanges();
            }

        }
    }
}
