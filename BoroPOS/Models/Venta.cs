using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class Venta
    { 
        public int Id { get; set; }
        public int SucursalId { get; set; }
        public int EmpleadoId { get; set; }
        public decimal Subtotal { get; set; } = 0m;
        public decimal Descuento { get; set; } = 0m;
        public decimal Total { get; set; } = 0m;
        public string MetodoPago { get; set; } = "efectivo";
        public decimal? MontoRecibido { get; set; }
        public decimal? Cambio { get; set; }
        public string Estado { get; set; } = "completada"; // completada, cancelada
        public string? Notas { get; set; }
        public bool Sincronizado { get; set; } = false;
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Sucursal Sucursal { get; set; } = new();
        public Empleado Empleado { get; set; } = new();
        public List<DetalleVenta> DetallesVenta { get; set; } = new();
    }
}
