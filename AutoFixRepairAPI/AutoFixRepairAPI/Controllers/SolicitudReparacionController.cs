using System;
using Microsoft.AspNetCore.Mvc;
using AutoFixRepairAPI.Models;
using AutoFixRepairAPI.Services;

namespace AutoFixRepairAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudReparacionController : ControllerBase
    {
        private readonly SolicitudReparacionServices _solicitudReparacionServices;

        public SolicitudReparacionController(SolicitudReparacionServices solicitudReparacionServices)
        {
            _solicitudReparacionServices = solicitudReparacionServices ?? throw new ArgumentNullException(nameof(solicitudReparacionServices));
        }

        [HttpGet]
        public IActionResult ObtenerTodasLasSolicitudes()
        {
            var solicitudes = _solicitudReparacionServices.ObtenerTodasLasSolicitudes();
            return Ok(solicitudes);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerSolicitudPorId(int id)
        {
            var solicitud = _solicitudReparacionServices.ObtenerSolicitudPorId(id);
            if (solicitud == null)
            {
                return NotFound();
            }
            return Ok(solicitud);
        }

        [HttpPost]
        public IActionResult CrearSolicitudReparacion([FromBody] SolicitudReparacion nuevaSolicitud)
        {
            _solicitudReparacionServices.CrearSolicitud(nuevaSolicitud);
            return CreatedAtAction(nameof(ObtenerSolicitudPorId), new { id = nuevaSolicitud.Id }, nuevaSolicitud);
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarSolicitudReparacion(int id, [FromBody] SolicitudReparacion solicitudActualizada)
        {
            if (id != solicitudActualizada.Id)
            {
                return BadRequest();
            }

            _solicitudReparacionServices.ActualizarSolicitud(solicitudActualizada);
            return NoContent();
        }

    }
}
