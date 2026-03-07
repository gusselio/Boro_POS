using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class CorteCaja
    {
        public int Id { get; set; }
        public int SucursalId { get; set; }
        public int TerminalId { get; set; }
        public string Turno { get; set; } = "mañana"; // mañana, tarde
        public int EmpleadoAperturaId { get; set; }
        public int? EmpleadoCierreId { get; set; }
        //Fondo
        public decimal FondoInicial { get; set; } = 0m;
        public decimal FondoSiguiente { get; set; } = 0m;

        //Ventas del turno
        public decimal TotalVentasEfectivo { get; set; } = 0m;
        public decimal TotalVentasTarjeta { get; set; } = 0m;
        public decimal TotalVentasTransfer { get; set; } = 0m;
        public decimal TotalVentas { get; set; } = 0m;

        //Conteo físico
        public decimal EfectivoContado { get; set; } = 0m;
        public decimal EfectivoEsperado { get; set; } = 0m;
        public decimal Diferencia { get; set; } = 0m;

        //Control de cierre
        public bool CerradoForzado { get; set; } = false;
        public int? CerradoForzadoPor { get; set; }
        public string CerradoDesde { get; set; } = "sucursal"; // sucursal, remoto

        //Estado
        public string Estado { get; set; } = "abierto"; // abierto, cerrado
        public string? Notas { get; set; }
        public bool Sincronizado { get; set; } = false;
        public DateTime AbiertoEn { get; set; } = DateTime.Now;
        public DateTime? CerradoEn { get; set; }

        //Relaciones
        public Terminal Terminal { get; set; } = new();
        public Sucursal Sucursal { get; set; } = new();
        public Empleado EmpleadoApertura { get; set; } = new();
        public Empleado? EmpleadoCierre { get; set; }
        public Empleado? EmpleadoCierreForzado { get; set; }
    }
}
