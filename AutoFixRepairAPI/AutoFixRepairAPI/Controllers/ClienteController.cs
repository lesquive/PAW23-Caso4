using System;
using System.Collections.Generic;
using AutoFixRepairAPI.Models;
using AutoFixRepairAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoFixRepairAPI.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteServices _clienteService;

        public ClienteController(ClienteServices clienteService)
        {
            _clienteService = clienteService ?? throw new ArgumentNullException(nameof(clienteService));
        }

        [HttpGet]
        public ActionResult<List<Cliente>> ObtenerTodosLosClientes()
        {
            var clientes = _clienteService.ObtenerTodosLosClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> ObtenerClientePorId(int id)
        {
            var cliente = _clienteService.ObtenerClientePorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public ActionResult<Cliente> CrearCliente(Cliente nuevoCliente)
        {
            _clienteService.CrearCliente(nuevoCliente);
            return CreatedAtAction(nameof(ObtenerClientePorId), new { id = nuevoCliente.ClienteId }, nuevoCliente);
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarCliente(int id, Cliente clienteActualizado)
        {
            if (id != clienteActualizado.ClienteId)
            {
                return BadRequest();
            }

            var clienteExistente = _clienteService.ObtenerClientePorId(id);
            if (clienteExistente == null)
            {
                return NotFound();
            }

            _clienteService.ActualizarCliente(clienteActualizado);
            return NoContent();
        }
    }
}
