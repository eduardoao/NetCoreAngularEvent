using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        public string Get()
        {
           return "teste";
        }
    }
}
