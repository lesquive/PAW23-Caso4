using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoFixRepairAPI.Models;
using AutoFixRepairAPI.Services;

namespace AutoFixRepairAPI.Controllers
{
    [Route("api/SolicitudReparacion")]
    [ApiController]
    public class SolicitudReparacionController : ControllerBase
    {
        private readonly SolicitudReparacionServices _solicitudReparacionServices;

        public SolicitudReparacionController(SolicitudReparacionServices solicitudReparacionServices)
        {
            _solicitudReparacionServices = solicitudReparacionServices ?? throw new ArgumentNullException(nameof(solicitudReparacionServices));
        }

        [HttpGet]
        public ActionResult<List<SolicitudReparacion>> ObtenerTodasLasSolicitudes()
        {
            var solicitudes = _solicitudReparacionServices.ObtenerTodasLasSolicitudes();
            return Ok(solicitudes);
        }

        [HttpGet("{id}")]
        public ActionResult<SolicitudReparacion> ObtenerSolicitudPorId(int id)
        {
            var solicitud = _solicitudReparacionServices.ObtenerSolicitudPorId(id);
            if (solicitud == null)
            {
                return NotFound();
            }
            return Ok(solicitud);
        }

        [HttpPost]
        public ActionResult<SolicitudReparacion> CrearSolicitud(SolicitudReparacion nuevaSolicitud)
        {
            var createdSolicitud = _solicitudReparacionServices.CrearSolicitud(nuevaSolicitud);
            return CreatedAtAction(nameof(ObtenerSolicitudPorId), new { id = createdSolicitud.Id }, createdSolicitud);
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarSolicitudReparacion(int id, SolicitudReparacion solicitudActualizada)
        {
            if (id != solicitudActualizada.Id)
            {
                return BadRequest();
            }

            var solicitudExistente = _solicitudReparacionServices.ObtenerSolicitudPorId(id);
            if (solicitudExistente == null)
            {
                return NotFound();
            }

            _solicitudReparacionServices.ActualizarSolicitud(solicitudActualizada);
            return NoContent();
        }
    }
}
