using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class Terminal
    {
        public int Id { get; set; }
        public int SucursalId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public string Tema { get; set; } = "light"; // light, dark
        public bool Activo { get; set; } = true;
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Sucursal Sucursal { get; set; } = new();
        public List<CorteCaja> CortesCaja { get; set; } = new();
    }
}
