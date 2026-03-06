using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public int NegocioId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public string UnidadMedida { get; set; } = "unidad"; // 'ml', 'gr', 'pieza', 'kg', 'lt'
        public decimal StockMinimoBodega { get; set; } = 0m;
        public decimal StockMinimoCocina { get; set; } = 0m;
        public decimal? CostoUnitario { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Negocio Negocio { get; set; } = new();
        public List<Receta> Recetas { get; set; } = new();
        public List<IngredienteAlmacen> IngredienteAlmacenes { get; set; } = new();
        public List<MovimientoAlmacen> MovimientosAlmacen { get; set; } = new();
    }
}
