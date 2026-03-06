using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public  class Turno
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public int SucursalId { get; set; }
        public string MetodoEntrada { get; set; } = "pin"; // pin, biometrico, manual
        public string? MetodoSalida { get; set; }
        public DateTime Entrada { get; set; } = DateTime.Now;
        public DateTime? Salida { get; set; }
        public TimeSpan? EntradaEsperada { get; set; }
        public TimeSpan? SalidaEsperada { get; set; }
        public int MinutosRetraso { get; set; } = 0;
        public string? Notas { get; set; }
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Empleado Empleado { get; set; } = new();
        public Sucursal Sucursal { get; set; } = new();

    }
}
