using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixRepairAPI.Models;

namespace AutoFixRepairAPI.Services
{
    public class SolicitudReparacionServices
    {
        private readonly AutoFixDbContext _context;

        public SolicitudReparacionServices(AutoFixDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<SolicitudReparacion> ObtenerTodasLasSolicitudes()
        {
            return _context.SolicitudesReparacion.ToList();
        }

        public SolicitudReparacion CrearSolicitud(SolicitudReparacion nuevaSolicitud)
        {
            _context.SolicitudesReparacion.Add(nuevaSolicitud);
            _context.SaveChanges();
            return nuevaSolicitud;
        }

        public void ActualizarSolicitud(SolicitudReparacion solicitudActualizada)
        {
            _context.SolicitudesReparacion.Update(solicitudActualizada);
            _context.SaveChanges();
        }

        public SolicitudReparacion ObtenerSolicitudPorId(int id)
        {
            return _context.SolicitudesReparacion.FirstOrDefault(s => s.Id == id);
        }

    }
}
