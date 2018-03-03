using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eventos.DAL.Models
{
    public class Participante
    {
        //Quests Adicionais
        [ForeignKey(name: "IdEvento")]
        public Evento IdEvento { get; set; }
        [Required]
        public string NomeParticipante { get; set; }
        public string Email { get; set; }
    }
}