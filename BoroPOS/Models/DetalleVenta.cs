using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class DetalleVenta
    { 
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; } = 1;
        public decimal PrecioUnitario { get; set; } = 0;
        public decimal Subtotal { get; set; } = 0;

        //Relaciones
        public Venta Venta { get; set; } = new();
        public Producto Producto { get; set; } = new();

    }
}
