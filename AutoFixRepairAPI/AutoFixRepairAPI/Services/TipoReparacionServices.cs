using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixRepairAPI.Models;

namespace AutoFixRepairAPI.Services
{
    public class TipoReparacionServices
    {
        private readonly AutoFixDbContext _context;

        public TipoReparacionServices(AutoFixDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<TipoReparacion> ObtenerTodosLosTiposReparacion()
        {
            return _context.TiposReparacion.ToList();
        }

        public void CrearTipoReparacion(TipoReparacion nuevoTipoReparacion)
        {
            _context.TiposReparacion.Add(nuevoTipoReparacion);
            _context.SaveChanges();
        }

        public void ActualizarTipoReparacion(TipoReparacion tipoReparacionActualizado)
        {
            _context.TiposReparacion.Update(tipoReparacionActualizado);
            _context.SaveChanges();
        }

        public TipoReparacion ObtenerTipoReparacionPorId(int id)
        {
            return _context.TiposReparacion.FirstOrDefault(t => t.Id == id);
        }
    }
}
