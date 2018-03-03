using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Eventos.DAL.ModelView;
using Eventos.BLL;


namespace Eventos.App.Controllers
{
    [Route("api/Evento")]
    public class EventoController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] EventoModelView eventoModelView)
        {
            try
            {
                var eventoBll = new EventoBll();
                eventoBll.Insert(eventoModelView);
                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        //api/Evento/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EventoModelView eventoModelView)
        {
            try
            {
                var eventoBll = new EventoBll();
                eventoBll.Atualizar(id, eventoModelView);
                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        //api/Evento/5
        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {
            try
            {
                var eventoBll = new EventoBll();
                var evento = eventoBll.ObterPorId(id);
                return Json(evento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        //api/Evento/5
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var eventoBll = new EventoBll();
                var listaDeEventos = eventoBll.ObterTodos();
                return Json(listaDeEventos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }


    }
}