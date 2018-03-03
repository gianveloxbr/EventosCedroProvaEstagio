using Eventos.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventos.DAL.ObjetosDeAcesso
{
    public class ParticipanteDAO
    {
        public void Inserir(Participante participante)
        {
            using (var DataBase = new DataBase())
            {
                DataBase.Participantes.Add(participante);
                DataBase.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var DataBase = new DataBase())
            {
                var participante = ObterPorId(id);
                DataBase.Participantes.Remove(participante);
                DataBase.SaveChanges();
            }
        }


        public void Atualizar(Participante participante)
        {
            using (var DataBase = new DataBase())
            {
                DataBase.Participantes.Update(participante);
                DataBase.SaveChanges();
            }
        }

        public List<Participante> ObterTodos()
        {
            using (var DataBase = new DataBase())
            {
                return DataBase.Participantes.ToList();
            }
        }

        public Participante ObterPorId(int id)
        {
            using (var DataBase = new DataBase())
            {
                return DataBase.Participantes.Find(id);
            }
        }
    }
}