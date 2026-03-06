using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class Negocio
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? RazonSocial { get; set; }
        public string? Rfc { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? LogoUrl { get; set; }
        public string? ColorPrimario { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        // Relaciones
        public List<Sucursal> Sucursales { get; set; } = new();
        public List<Empleado> Empleados { get; set; } = new();
        public List<Categoria> Categorias { get; set; } = new();
        public List<Ingrediente> Ingredientes { get; set; } = new();
    }
}