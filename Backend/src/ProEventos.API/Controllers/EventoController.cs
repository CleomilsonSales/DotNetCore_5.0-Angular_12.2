using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
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
            return "value";
            /*return new Evento(){
                Eventoid = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Ceará",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.

            };*/
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo Put com o id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo Delete com o id = {id}";
        }
    }
}
