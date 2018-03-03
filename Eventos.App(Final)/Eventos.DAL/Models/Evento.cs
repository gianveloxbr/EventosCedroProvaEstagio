using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eventos.DAL.Models
{
    public class Evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvento { get; set; }
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
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan HoraInicio { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan HoraFim { get; set; }
        [Required]
        public bool OpenBar { get; set; }
        public int QuantidadeDeAmbientes { get; set; }
        [Required]
        [Range(0, 18)]
        public string FaixaEtaria { get; set; }
		
		//Quests Adicionais
		[Required]
		public int MaximoIngressos{get; set;}
		[Required]
		public int IngressosVendidos{get; set;}
		public string Ingressos{get; set;}
    }
}
