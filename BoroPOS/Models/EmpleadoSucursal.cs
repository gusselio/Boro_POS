using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class  EmpleadoSucursal
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public int SucursalId { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime? FechaFin { get; set; }
        public bool Activo { get; set; } = true;
        
        //Relaciones
        public Empleado Empleado { get; set; } = new();
        public Sucursal Sucursal { get; set; } = new();

    }
}
