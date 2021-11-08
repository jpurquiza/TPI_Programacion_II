using Microsoft.AspNetCore.Mvc;
using BancoBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoBackend.Servicios;
using BancoBackend.Cache;

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

        [HttpPost("login")]
        public IActionResult Login(UserLogin oUsuario)
        {
            return Ok(gestor.Login(oUsuario.DNI, oUsuario.Pass));
        }

        // POST api/<DestinatariosController>
        [HttpPost("altaCliente")]
        public IActionResult AltaCliente(Cliente oCliente)
        {
            return Ok(gestor.AltaCliente(oCliente));
        }

        //// PUT api/<DestinatariosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<DestinatariosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}




        [HttpPost("altaDestinatario")]
        public IActionResult InsertDestinatario(Destinatarios oDestinatario)
        {
            if (oDestinatario == null)
            {
                return BadRequest();
            }

            if (gestor.GrabarDestinatario(oDestinatario))
                return Ok("Ok");
            else
                return Ok("No se pudo grabar el destinatario");
        }

        [HttpPost("modificarDestinatario")]
        public IActionResult UpdateDestintario(Destinatarios oDestinatario)
        {
            if (oDestinatario == null)
            {
                return BadRequest();
            }

            if (gestor.EditarDestinatario(oDestinatario))
                return Ok("Ok");
            else
                //BR o OK
                return Ok("No se pudo modificar el destinatario");
        }

        [HttpDelete("{idDestinatario}")]
        public void DeleteDestinatario(int idDestinatario)
        {
            gestor.EliminarDestinatario(idDestinatario);
        }
    }
}
