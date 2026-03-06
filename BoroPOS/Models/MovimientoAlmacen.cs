using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class MovimientoAlmacen
    {
        public int Id { get; set; }
        public int IngredienteId { get; set; }
        public int? AlmacenOrigenId { get; set; }
        public int? AlmacenDestinoId { get; set; }
        public int EmpleadoId { get; set; }
        public string Tipo { get; set; } = "entrada"; // entrada, traspaso, consumo, merma
        public decimal Cantidad { get; set; } = 0m;
        public decimal? CostoUnitario { get; set; }
        public string? Notas { get; set; }
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Ingrediente Ingrediente { get; set; } = new();
        public Empleado Empleado { get; set; } = new();
        public Almacen? AlmacenOrigen { get; set; }
        public Almacen? AlmacenDestino { get; set; }
    }
}
