using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventos.AcessoADados.ModelView
{
    public class EventoModelView
    {
        [Required]
        public string Nome { get; set; }
        public string Data { get; set; }
        public string Local { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFim { get; set; }
        [Required]
        public bool OpenBar { get; set; }
        public int QuantidadeDeAmbientes { get; set; }
        public int MaximoIngressos { get; set; }
        public int IngressosVendidos { get; set; }
        public string qtde_ingressos { get; set; }
        public string EMail { get; set; }
    }
}
