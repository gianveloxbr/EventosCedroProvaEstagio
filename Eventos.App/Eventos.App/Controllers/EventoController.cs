using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.App.Controllers
{
    [Produces("application/json")]
    [Route("api/Evento")]
    public class EventoController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] EventoModelView eventoModelView)
        {
            try
            {
                var eventoBll = new EventoBll();
                eventoBll.Inserir(eventoModelView);
                return NoContent();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, "Sucesso.");
            }
        }
    }
}