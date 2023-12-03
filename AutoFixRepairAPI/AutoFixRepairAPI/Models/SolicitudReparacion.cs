using System;
namespace AutoFixRepairAPI.Models
{
    public class SolicitudReparacion
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int TipoReparacionId { get; set; }
        public TipoReparacion TipoReparacion { get; set; }

        public int? IdMecanicoAsignado { get; set; }

        public bool Completada { get; set; } 
    }
}
