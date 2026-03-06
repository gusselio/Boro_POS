using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class Almacen
    {
        public int Id { get; set; }
        public int SucursalId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Tipo { get; set; } = "bodega"; // bodega, cocina
        public string? Descripcion { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Sucursal Sucursal { get; set; } = new();
        public List<IngredienteAlmacen> IngredienteAlmacenes { get; set; } = new();
        public List<MovimientoAlmacen> MovimientosAlmacen { get; set; } = new();
    }
}
