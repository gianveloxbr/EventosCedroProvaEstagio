using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eventos.AcessoADados.Modelos
{
    public class Participante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Evento IdEvento { get; set; }
        [Required]
        public string Nome_Participante { get; set; }
        public string EMail_Participante { get; set; }
    }
}
