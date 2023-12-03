using System;
using System.Collections.Generic;
using AutoFixRepairAPI.Models;
using AutoFixRepairAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoFixRepairAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoReparacionController : ControllerBase
    {
        private readonly TipoReparacionServices _tipoReparacionService;

        public TipoReparacionController(TipoReparacionServices tipoReparacionService)
        {
            _tipoReparacionService = tipoReparacionService ?? throw new ArgumentNullException(nameof(tipoReparacionService));
        }

        [HttpGet]
        public ActionResult<List<TipoReparacion>> ObtenerTodosLosTiposReparacion()
        {
            var tiposReparacion = _tipoReparacionService.ObtenerTodosLosTiposReparacion();
            return Ok(tiposReparacion);
        }

        [HttpPost]
        public ActionResult CrearTipoReparacion([FromBody] TipoReparacion nuevoTipoReparacion)
        {
            _tipoReparacionService.CrearTipoReparacion(nuevoTipoReparacion);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult ActualizarTipoReparacion(int id, [FromBody] TipoReparacion tipoReparacionActualizado)
        {
            var tipoReparacionExistente = _tipoReparacionService.ObtenerTipoReparacionPorId(id);
            if (tipoReparacionExistente == null)
            {
                return NotFound();
            }

            tipoReparacionActualizado.Id = id;
            _tipoReparacionService.ActualizarTipoReparacion(tipoReparacionActualizado);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<TipoReparacion> ObtenerTipoReparacionPorId(int id)
        {
            var tipoReparacion = _tipoReparacionService.ObtenerTipoReparacionPorId(id);
            if (tipoReparacion == null)
            {
                return NotFound();
            }

            return Ok(tipoReparacion);
        }
    }
}
