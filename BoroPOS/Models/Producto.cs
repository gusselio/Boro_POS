using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class Producto
    { 
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public int NegocioId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; } = 0m;
        public decimal? Costo { get; set; }
        public int Stock { get; set; } = 0;
        public int StockMinimo { get; set; } = 5;
        public string? ImagenUrl { get; set; }
        public string? CodigoBarras { get; set; }
        public bool Disponible { get; set; } = true;
        public bool Activo { get; set; } = true;
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Categoria Categoria { get; set; } = new();
        public Negocio Negocio { get; set; } = new();
        public List<Receta> Recetas { get; set; } = new();
        public List<DetalleVenta> DetallesVenta { get; set; } = new();
    }
}
