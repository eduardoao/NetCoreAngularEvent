using System;
using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {  
        public EventoController()
        {
          
        }

        [HttpGet]
        public IEnumerable<Evento>  Get()
        {    
            return _evento;      
        }


        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {    
            return _evento.Where (evento => evento.EventId == id );              
        }

        private IEnumerable<Evento> _evento = new Evento[] {               
               new Evento(){                   
               EventId = 1,
               DataEvento = DateTime.Now,
               ImagemURL = "https://media.gettyimages.com/photos/artificial-intelligence-picture-id1198086928",
               Local = "São Paulo",
               Lote = "1",
               QuantidadePessoas = 200,
               Tema = "Angular 11"          
               },
               new Evento(){                   
               EventId = 2,
               DataEvento = DateTime.Now,
               ImagemURL = "https://media.gettyimages.com/photos/artificial-intelligence-picture-id1198086928",
               Local = "São Paulo",
               Lote = "2",
               QuantidadePessoas = 200,
               Tema = "Angular 11"          
               }
           };
    }
}
