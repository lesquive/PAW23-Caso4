using System;
using Microsoft.AspNetCore.Mvc;
using AutoFixRepairAPI.Models;
using AutoFixRepairAPI.Services;

namespace AutoFixRepairAPI.Controllers
{
    [Route("api/servicios")]
    [ApiController]
    public class InformacionServiciosController : ControllerBase
    {
        private readonly InformacionServiciosServices _serviciosService;

        public InformacionServiciosController(InformacionServiciosServices serviciosService)
        {
            _serviciosService = serviciosService ?? throw new ArgumentNullException(nameof(serviciosService));
        }

        [HttpGet]
        public IActionResult ObtenerTodosLosServicios()
        {
            var servicios = _serviciosService.ObtenerTodosLosServicios();
            return Ok(servicios);
        }

        [HttpPost]
        public IActionResult CrearServicio([FromBody] InformacionServicios nuevoServicio)
        {
            _serviciosService.CrearServicio(nuevoServicio);
            return Ok("Servicio creado exitosamente.");
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarServicio(int id, [FromBody] InformacionServicios servicioActualizado)
        {
            var servicioExistente = _serviciosService.ObtenerServicioPorId(id);

            if (servicioExistente == null)
            {
                return NotFound();
            }

            servicioActualizado.Id = id;
            _serviciosService.ActualizarServicio(servicioActualizado);

            return Ok("Servicio actualizado exitosamente.");
        }
    }
}
