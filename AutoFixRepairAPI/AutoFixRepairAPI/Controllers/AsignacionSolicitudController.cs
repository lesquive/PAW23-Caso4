using Microsoft.AspNetCore.Mvc;
using AutoFixRepairAPI.Services;

namespace AutoFixRepairAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsignacionSolicitudController : ControllerBase
    {
        private readonly AsignacionSolicitudService _asignacionSolicitudService;

        public AsignacionSolicitudController(AsignacionSolicitudService asignacionSolicitudService)
        {
            _asignacionSolicitudService = asignacionSolicitudService;
        }

        [HttpPost("asignar-mecanico")]
        public IActionResult AsignarSolicitudAMecanico(int idSolicitud, int idMecanico)
        {
            _asignacionSolicitudService.AsignarSolicitudAMecanico(idSolicitud, idMecanico);
            return Ok("Solicitud asignada al mecánico correctamente.");
        }

        [HttpPost("marcar-completada")]
        public IActionResult MarcarSolicitudComoCompletada(int idSolicitud)
        {
            _asignacionSolicitudService.MarcarSolicitudComoCompletada(idSolicitud);
            return Ok("Solicitud marcada como completada.");
        }
    }
}
