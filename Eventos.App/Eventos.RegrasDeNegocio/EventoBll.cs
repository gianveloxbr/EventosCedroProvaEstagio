using Eventos.AcessoADados.Modelos;
using Eventos.AcessoADados.ModelView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.RegrasDeNegocio
{
    public class EventoBll
    {
        public void Inserir(EventoModelView eventoModelView)
        {
            var evento = new Evento();

            evento = PrepararEvento(eventoModelView, evento);
            var eventoDao = new EventoDAO();
            eventoDao.Inserir(evento);
        }

        public void Atualizar(int id, EventoModelView eventoModelView)
        {
            var eventoDao = new EventoDAO();
            var evento = eventoDao.ObterPorId(id);
            evento = PrepararEvento(eventoModelView, evento);
            eventoDao.Atualizar(evento);
        }

        public Evento ObterPorId(int id)
        {
            var eventoDao = new EventoDAO();
            return eventoDao.ObterPorId(id);
        }

        public void Apagar(int id)
        {
            var eventoDao = new EventoDAO();
            eventoDao.Apagar(id);
        }

        public List<Evento> ObterTodos()
        {
            var eventoDao = new EventoDAO();
            return eventoDao.ObterTodos();
        }

        public Evento PrepararEvento(EventoModelView eventoModelView, Evento evento)
        {
            evento.Data = eventoModelView.Data;
            evento.Nome = eventoModelView.Nome;
            evento.HoraInicio = eventoModelView.HoraInicio;
            evento.HoraFim = eventoModelView.HoraFim;
            evento.Local = eventoModelView.Local;
            evento.OpenBar = eventoModelView.OpenBar;
            evento.QuantidadeDeAmbientes = evento.QuantidadeDeAmbientes;
            evento.MaximoIngressos = eventoModelView.MaximoIngressos;
            evento.IngressosVendidos = eventoModelView.IngressosVendidos;
            evento.qtde_ingressos = eventoModelView.qtde_ingressos;

            if (evento.HoraInicio > 10 && evento.HoraFim < 20 && evento.QuantidadeDeAmbientes > 2)
            {
                evento.FaixaEtaria = "Menor que 16 anos";
            }
            else if (evento.HoraInicio > 20 && evento.HoraFim < 2 && evento.OpenBar == false)
            {
                evento.FaixaEtaria = "Maior que 16 anos";
            }
            else
            {
                evento.FaixaEtaria = "Maior que 18 anos";
            }

            //Quests Bônus ;)
            if(evento.IngressosVendidos == evento.MaximoIngressos)
            {
                evento.qtde_ingressos = "Parece que os ingressos esgotaram. :/";
            }

            else
            {
                evento.qtde_ingressos = "Tudo certo, ainda temos ingressos. :)";
            }

            return evento;
        }
    }
}
