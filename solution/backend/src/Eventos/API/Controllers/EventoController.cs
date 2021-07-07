using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public DataContext _dataContext { get; }
        public EventoController(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _dataContext.Eventos;
        }


        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _dataContext.Eventos.Where(evento => evento.EventId == id).FirstOrDefault();
        }
    }
}
