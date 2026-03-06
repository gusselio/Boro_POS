using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class  Categoria
    {
        public int Id { get; set; }
        public int NegocioId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public string? Color { get; set; }
        public string? IconoUrl { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Negocio Negocio { get; set; } = new();
        public List<Producto> Productos { get; set; } = new();
    }
}
