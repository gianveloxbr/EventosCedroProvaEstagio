using Eventos.DAL.DAO;
using Eventos.DAL.Models;
using Eventos.DAL.ModelView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.BLL
{
    public class EventoBll
    {
        public void Insert(EventoModelView eventoModelView)
        {
            var evento = new Evento();
            evento = PrepararEvento(eventoModelView, evento);

            var eventoDAO = new EventoDAO();
            eventoDAO.Inserir(evento);
        }

        public void Atualizar(int id, EventoModelView eventoModelView)
        {
            var eventoDAO = new EventoDAO();
            var evento = eventoDAO.ObterPorId(id);

            evento = PrepararEvento(eventoModelView, evento);

            eventoDAO.Atualizar(evento);
        }

        public List<Evento> ObterTodos()
        {
            var eventoDAO = new EventoDAO();
            return eventoDAO.ObterTodos();
        }
        public Evento ObterPorId(int id)
        {
            var eventoDAO = new EventoDAO();
            return eventoDAO.ObterPorId(id);
        }

        public void Delete(int id)
        {
            var eventoDAO = new EventoDAO();
            eventoDAO.Deletar(id);
        }

        public Evento PrepararEvento(EventoModelView eventoModelView, Evento evento)
        {
            evento.NomeEvento = eventoModelView.Nome;
            evento.Data = eventoModelView.Data;
			evento.Local = eventoModelView.Local;
            evento.HoraInicio = eventoModelView.HoraIncio;
            evento.HoraFim = eventoModelView.HoraFim;
            evento.OpenBar = eventoModelView.OpenBar;
            evento.QuantidadeDeAmbientes = eventoModelView.QuantidadeDeAmbientes;
            evento.FaixaEtaria = eventoModelView.FaixaEtaria;

            if(evento.HoraInicio.Hour > 10 && evento.HoraFinal.Hour < 20 && evento.QuantidadeAmbientes > 2)
            {
                evento.FaixaEtaria = "Menor que 16 anos.";
            }
            else
                if (evento.HoraInicio.Hour > 20 && evento.HoraFinal.Hour < 2 && evento.OpenBar == false)
            {
                evento.FaixaEtaria = "Maior que 16 anos.";
            }
            else
            {
                evento.FaixaEtaria = "Maior que 18 anos.";
            }
            

            //Quests Adicionais
            evento.MaximoIngressos = eventoModelView.MaximoIngressos;
            evento.IngressosVendidos = eventoModelView.IngressosVendidos;
            evento.Ingressos = eventoModelView.Ingressos;

            if(evento.IngressosVendidos == evento.MaximoIngressos)
            {
                evento.Ingressos = "Todos os ingressos estão esgotados.";
            }
            else
            {
                evento.Ingressos = "Ainda há Ingressos Disponíveis.";
            }

            return evento;
        }

        }
    }
}