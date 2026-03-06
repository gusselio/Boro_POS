using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public int NegocioId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        // Relaciones
        public Negocio Negocio { get; set; } = new();
        public List<EmpleadoSucursal> EmpleadoSucursales { get; set; } = new();
        public List<Venta> Ventas { get; set; } = new();   
        public List<Turno> Turnos { get; set; } = new();
        public List<CorteCaja> CortesCaja { get; set; } = new();
        public List<Almacen> Almacenes { get; set; } = new();
    }
}
