using System;
using System.Linq;
using AutoFixRepairAPI.Models;

namespace AutoFixRepairAPI.Services
{
    public class AsignacionSolicitudService
    {
        private readonly AutoFixDbContext _context;

        public AsignacionSolicitudService(AutoFixDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AsignarSolicitudAMecanico(int idSolicitud, int idMecanico)
        {
            var solicitud = _context.SolicitudesReparacion.FirstOrDefault(s => s.Id == idSolicitud);
            if (solicitud != null)
            {
                solicitud.IdMecanicoAsignado = idMecanico;
                _context.SaveChanges();
            }
        }

        public void MarcarSolicitudComoCompletada(int idSolicitud)
        {
            var solicitud = _context.SolicitudesReparacion.FirstOrDefault(s => s.Id == idSolicitud);
            if (solicitud != null)
            {
                solicitud.Completada = true;
                _context.SaveChanges();
            }
        }
    }
}
