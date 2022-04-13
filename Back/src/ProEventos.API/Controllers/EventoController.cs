using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using System;
using System.Collections.Generic;

namespace ProEventos.API.Controllers
{
    [ApiController]
  [Route("api/controller")]
  public class EventoController : ControllerBase
  {
    public IEnumerable<Evento> _evento = new Evento[] {
        new Evento(){
        EventoId = 1,
        Tema = "Angular 11 e .NET 5",
        Local = "Mato Grosso",
        Lote = "1 Lote",
        QtdPessoas = 250,
        DataEvento = DateTime.Now.AddDays(2).ToString()
        }
      };
    public EventoController()
    {
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
      return _evento;
    }

    [HttpPost]
    public string Post()
    {
      return "Exemplo de post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
      return $"Exemplo de Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
      return $"Exemplo de Delete com id = {id}";
    }
  }
}
