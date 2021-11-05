using Microsoft.AspNetCore.Mvc;
using BancoBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoBackend.Servicios;
using BancoBackend.Cache;


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

        [HttpGet("cuentas")]
        public IActionResult GetCuentas()
        {
            return Ok(gestor.GetCuentas());
        }

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

        [HttpPost("altaCliente")]
        public IActionResult AltaCliente(Cliente oCliente)
        {
            return Ok(gestor.AltaCliente(oCliente));
        }
        
        [HttpPost("altaDestinatario")]
        public IActionResult InsertReceta(Destinatarios oDestinatario)
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
        public IActionResult UpdateReceta(Destinatarios oDestinatario)
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

        [HttpPost("altaTransferencia")]
        public IActionResult GrabarTransferencia(Transferencia oTransferencia)
        {

            return Ok(gestor.GrabarTransferencia(oTransferencia));

        }

        [HttpGet("proximoID")]
        public IActionResult GetProximoID()
        {
            return Ok(gestor.GetProximoID().ToString());
        }
    }
    
}
