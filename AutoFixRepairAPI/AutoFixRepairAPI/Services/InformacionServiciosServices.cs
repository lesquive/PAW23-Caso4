using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixRepairAPI.Models;

namespace AutoFixRepairAPI.Services
{
    public class InformacionServiciosServices
    {
        private readonly AutoFixDbContext _context;

        public InformacionServiciosServices(AutoFixDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<InformacionServicios> ObtenerTodosLosServicios()
        {
            return _context.InformacionServicios.ToList();
        }

        public void CrearServicio(InformacionServicios nuevoServicio)
        {
            _context.InformacionServicios.Add(nuevoServicio);
            _context.SaveChanges();
        }

        public void ActualizarServicio(InformacionServicios servicioActualizado)
        {
            _context.InformacionServicios.Update(servicioActualizado);
            _context.SaveChanges();
        }

        public InformacionServicios ObtenerServicioPorId(int id)
        {
            return _context.InformacionServicios.FirstOrDefault(s => s.Id == id);
        }
    }
}
