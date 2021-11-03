using Microsoft.AspNetCore.Mvc;
using BancoBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoBackend.Servicios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IGestorClientes gestor;

        public ClientesController()
        {
            gestor = new GestorClientes();
        }

        // GET: api/<DestinatariosController>
        [HttpGet("cuentas")]
        public IActionResult GetCuentas()
        {
            return Ok(gestor.GetCuentas());
        }

        // GET api/<DestinatariosController>/5
        [HttpGet("destinatarios")]
        public IActionResult GetDestinatarios()
        {
            return Ok(gestor.GetDestinatarios());
        }

        [HttpGet("login")]
        public IActionResult Login( int dniLogin, string claveLogin)
        {
            return Ok(gestor.Login(dniLogin, claveLogin));
        }

        // POST api/<DestinatariosController>
        [HttpPost("consultarCuentas")]
        public string Pendiente()
        {
            throw new NotImplementedException();
        }

        // PUT api/<DestinatariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DestinatariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
