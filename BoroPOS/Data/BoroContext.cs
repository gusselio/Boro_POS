using BoroPOS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BoroPOS.Data
{
    public class BoroContext : DbContext
    {
        public DbSet<Negocio> Negocios { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<EmpleadoSucursal> EmpleadoSucursales { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<CorteCaja> CortesCaja { get; set; }
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<IngredienteAlmacen> IngredienteAlmacenes { get; set; }
        public DbSet<MovimientoAlmacen> MovimientosAlmacen { get; set; }
        public DbSet<Receta> Recetas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("BoroDb");

            options.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            ).UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Decirle a EF que CorteCaja tiene DOS relaciones con Empleado
            modelBuilder.Entity<CorteCaja>()
                .HasOne(c => c.Empleado)
                .WithMany(e => e.CortesCaja)
                .HasForeignKey(c => c.EmpleadoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CorteCaja>()
                .HasOne(c => c.EmpleadoCierreForzado)
                .WithMany()
                .HasForeignKey(c => c.CerradoForzadoPor)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MovimientoAlmacen>()
                .HasOne(m => m.AlmacenOrigen)
                .WithMany()
                .HasForeignKey(m => m.AlmacenOrigenId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MovimientoAlmacen>()
                .HasOne(m => m.AlmacenDestino)
                .WithMany()
                .HasForeignKey(m => m.AlmacenDestinoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}