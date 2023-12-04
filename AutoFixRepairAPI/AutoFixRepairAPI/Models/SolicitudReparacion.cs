using System;

namespace AutoFixRepairAPI.Models
{
    public class SolicitudReparacion
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }

        public int TipoReparacionId { get; set; }

        public int? IdMecanicoAsignado { get; set; }

        public bool Completada { get; set; }

        // Propiedades relacionadas al automóvil
        public string ModeloAutomovil { get; set; }
        public string MarcaAutomovil { get; set; }
        public int AnioAutomovil { get; set; }
        public string PlacaAutomovil { get; set; }
    }
}
