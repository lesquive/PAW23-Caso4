using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace AutoFixRepairAPI.Models
{
    public class AutoFixDbContext : DbContext
    {
        public AutoFixDbContext(DbContextOptions<AutoFixDbContext> options) : base(options)
        {
        }

        public DbSet<InformacionServicios> InformacionServicios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<SolicitudReparacion> SolicitudesReparacion { get; set; }
        public DbSet<TipoReparacion> TiposReparacion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("AutoFixDbContext", new MySqlServerVersion(new Version(8, 0, 25)));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InformacionServicios>().HasData(
                new InformacionServicios { Id = 1, Titulo = "Reparación de Motor", Descripcion = "Especialistas en reparación de motores para automóviles de todas las marcas." },
                new InformacionServicios { Id = 2, Titulo = "Cambio de Neumáticos", Descripcion = "Servicio rápido y eficiente de cambio de neumáticos con las mejores marcas del mercado." },
                new InformacionServicios { Id = 3, Titulo = "Revisión y Mantenimiento", Descripcion = "Mantenimiento completo de automóviles para garantizar su rendimiento y durabilidad." },
                new InformacionServicios { Id = 4, Titulo = "Frenos y Suspensión", Descripcion = "Especialistas en reparación y mantenimiento de sistemas de frenos y suspensión." },
                new InformacionServicios { Id = 5, Titulo = "Aire Acondicionado", Descripcion = "Servicio de diagnóstico, reparación y mantenimiento de sistemas de aire acondicionado." },
                new InformacionServicios { Id = 6, Titulo = "Sistema Eléctrico", Descripcion = "Reparación y diagnóstico de problemas en el sistema eléctrico del automóvil." },
                new InformacionServicios { Id = 7, Titulo = "Cambio de Aceite", Descripcion = "Cambio de aceite y filtro con productos de calidad para el mejor rendimiento del motor." },
                new InformacionServicios { Id = 8, Titulo = "Inspección de Emisiones", Descripcion = "Servicio de inspección y corrección para cumplir con los estándares de emisiones." },
                new InformacionServicios { Id = 9, Titulo = "Reparación de Carrocería", Descripcion = "Reparación de daños en la carrocería con acabados de alta calidad." },
                new InformacionServicios { Id = 10, Titulo = "Diagnóstico Computarizado", Descripcion = "Diagnóstico avanzado mediante sistemas computarizados para problemas técnicos." },
                new InformacionServicios { Id = 11, Titulo = "Servicio de Emergencia", Descripcion = "Asistencia y reparación de emergencia las 24 horas del día, los 7 días de la semana." },
                new InformacionServicios { Id = 12, Titulo = "Servicio de Remolque", Descripcion = "Servicio de remolque para vehículos averiados hasta nuestro taller." },
                new InformacionServicios { Id = 13, Titulo = "Servicio de Mantenimiento Preventivo", Descripcion = "Programas de mantenimiento preventivo para evitar problemas futuros." }
            );

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { ClienteId = 1, Nombre = "Juan", Apellido = "García", Email = "juan@example.com", Telefono = "123456789", Direccion = "Calle Principal" },
                new Cliente { ClienteId = 2, Nombre = "María", Apellido = "López", Email = "maria@example.com", Telefono = "987654321", Direccion = "Avenida Central" },
                new Cliente { ClienteId = 3, Nombre = "Pedro", Apellido = "Martínez", Email = "pedro@example.com", Telefono = "456789123", Direccion = "Calle Secundaria" },
                new Cliente { ClienteId = 4, Nombre = "Ana", Apellido = "Rodríguez", Email = "ana@example.com", Telefono = "741852963", Direccion = "Plaza Principal" },
                new Cliente { ClienteId = 5, Nombre = "Carlos", Apellido = "Gómez", Email = "carlos@example.com", Telefono = "159263487", Direccion = "Avenida Norte" },
                new Cliente { ClienteId = 6, Nombre = "Laura", Apellido = "Díaz", Email = "laura@example.com", Telefono = "369852147", Direccion = "Calle Sur" },
                new Cliente { ClienteId = 7, Nombre = "Javier", Apellido = "Hernández", Email = "javier@example.com", Telefono = "258147369", Direccion = "Avenida Oeste" },
                new Cliente { ClienteId = 8, Nombre = "Sofía", Apellido = "Pérez", Email = "sofia@example.com", Telefono = "147852369", Direccion = "Calle Este" }

            );
            modelBuilder.Entity<SolicitudReparacion>().HasData(
                new SolicitudReparacion { Id = 1, ClienteId = 1, TipoReparacionId = 1, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A",MarcaAutomovil = "Marca X",AnioAutomovil = 2022, PlacaAutomovil = "XYZ456"},
                new SolicitudReparacion { Id = 2, ClienteId = 2, TipoReparacionId = 2, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A", MarcaAutomovil = "Marca X", AnioAutomovil = 2022, PlacaAutomovil = "XYZ456" },
                new SolicitudReparacion { Id = 3, ClienteId = 3, TipoReparacionId = 3, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A", MarcaAutomovil = "Marca X", AnioAutomovil = 2022, PlacaAutomovil = "XYZ456" },
                new SolicitudReparacion { Id = 4, ClienteId = 4, TipoReparacionId = 4, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A", MarcaAutomovil = "Marca X", AnioAutomovil = 2022, PlacaAutomovil = "XYZ456" },
                new SolicitudReparacion { Id = 5, ClienteId = 5, TipoReparacionId = 5, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A", MarcaAutomovil = "Marca X", AnioAutomovil = 2022, PlacaAutomovil = "XYZ456" },
                new SolicitudReparacion { Id = 6, ClienteId = 6, TipoReparacionId = 6, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A", MarcaAutomovil = "Marca X", AnioAutomovil = 2022, PlacaAutomovil = "XYZ456" },
                new SolicitudReparacion { Id = 7, ClienteId = 7, TipoReparacionId = 7, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A", MarcaAutomovil = "Marca X", AnioAutomovil = 2022, PlacaAutomovil = "XYZ456" },
                new SolicitudReparacion { Id = 8, ClienteId = 3, TipoReparacionId = 8, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A", MarcaAutomovil = "Marca X", AnioAutomovil = 2022, PlacaAutomovil = "XYZ456" },
                new SolicitudReparacion { Id = 9, ClienteId = 5, TipoReparacionId = 9, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A", MarcaAutomovil = "Marca X", AnioAutomovil = 2022, PlacaAutomovil = "XYZ456" },
                new SolicitudReparacion { Id = 10, ClienteId = 1, TipoReparacionId = 10, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A", MarcaAutomovil = "Marca X", AnioAutomovil = 2022, PlacaAutomovil = "XYZ456" },
                new SolicitudReparacion { Id = 11, ClienteId = 3, TipoReparacionId = 11, IdMecanicoAsignado = null, Completada = false, ModeloAutomovil = "Modelo A", MarcaAutomovil = "Marca X", AnioAutomovil = 2022, PlacaAutomovil = "XYZ456" }

            );

            modelBuilder.Entity<TipoReparacion>().HasData(
                new TipoReparacion { Id = 1, Nombre = "Reparación de Motor" },
                new TipoReparacion { Id = 2, Nombre = "Cambio de Neumáticos" },
                new TipoReparacion { Id = 3, Nombre = "Revisión y Mantenimiento" },
                new TipoReparacion { Id = 4, Nombre = "Frenos y Suspensión" },
                new TipoReparacion { Id = 5, Nombre = "Aire Acondicionado" },
                new TipoReparacion { Id = 6, Nombre = "Sistema Eléctrico" },
                new TipoReparacion { Id = 7, Nombre = "Cambio de Aceite" },
                new TipoReparacion { Id = 8, Nombre = "Inspección de Emisiones" },
                new TipoReparacion { Id = 9, Nombre = "Reparación de Carrocería" },
                new TipoReparacion { Id = 10, Nombre = "Diagnóstico Computarizado" },
                new TipoReparacion { Id = 11, Nombre = "Servicio de Emergencia" },
                new TipoReparacion { Id = 12, Nombre = "Servicio de Remolque" },
                new TipoReparacion { Id = 13, Nombre = "Servicio de Mantenimiento Preventivo" }
            );
        }
    }
}

