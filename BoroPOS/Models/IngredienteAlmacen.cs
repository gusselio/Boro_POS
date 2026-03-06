using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class IngredienteAlmacen
    {
        public int Id { get; set; }
        public int IngredienteId { get; set; }
        public int AlmacenId { get; set; }
        public decimal StockActual { get; set; } = 0;
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Ingrediente Ingrediente { get; set; } = new();
        public Almacen Almacen { get; set; } = new();

    }
}
