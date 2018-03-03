using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventos.DAL.ModelView
{
    public class EventoModelView
    {

        [Key]
		[Required]
        [StringLength(50)]
        public String NomeEvento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
		[Required]
        [StringLength(100)]
        public String Local { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)] //Formata as horas para serem mostradas corretamente.
        public TimeSpan HoraInicio { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan HoraFim { get; set; }
        [Required]
        public bool OpenBar { get; set; }
        public int QuantidadeDeAmbientes { get; set; }
        [Required]
        [Range(0, 18)] //Define a faixa de classificação dos Participantes.
        public string FaixaEtaria { get; set; }
		
		//Quests Adicionais
		[Required]
		public int MaximoIngressos{get; set;}
		[Required]
		public int IngressosVendidos{get; set;}
		public string Ingressos{get; set;}
    }
}
