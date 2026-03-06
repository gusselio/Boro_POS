using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class Receta
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int IngredienteId { get; set; }
        public decimal Cantidad { get; set; } = 0m;
        public string UnidadMedida { get; set; } = "unidad"; // 'ml', 'gr', 'pieza', 'kg', 'lt'
        public string? Notas { get; set; }
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Producto Producto { get; set; } = new();
        public Ingrediente Ingrediente { get; set; } = new();

    }
}
