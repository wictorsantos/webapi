﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {    public IEnumerable<Evento> _evento = new Evento[] {
                new Evento(){
                    EventoId =1,
                Tema = "Angular 11 e .Net 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                ImagemUrl = "Foto.png",
                DataEvento = DateTime.Now.AddDays(2).ToString()
                },
                 new Evento(){
                    EventoId =2,
                Tema = "Angular e suas novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 350,
                ImagemUrl = "Foto2.png",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/YYYY")
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
        [HttpGet ("{id}")]
        public IEnumerable<Evento> GetById(int id){
            return _evento.Where(evento => evento.EventoId == id);
        }
         [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
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
