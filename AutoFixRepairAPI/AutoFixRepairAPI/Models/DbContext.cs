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
    }
}

