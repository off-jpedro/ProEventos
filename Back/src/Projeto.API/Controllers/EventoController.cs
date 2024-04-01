using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using __Projeto.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace __Projeto.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _eventos = new Evento[]{
        
             new Evento() {              
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Goiás",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
                },

                new Evento () {
                EventoId = 2,
                Tema = "Angular 11 e .Net 5 e Suas Novidades",
                Local = "Paraná",
                Lote = "2º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
                }
            };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return  _eventos;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return  _eventos.Where( evento => evento.EventoId == id);
        }

         [HttpPost]
        public IEnumerable<Evento> Post()
        {
            return _eventos;
        }
   
        }

}

    

