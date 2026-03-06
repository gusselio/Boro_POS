using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Models
{
    public class Empleado
    { 
        public int Id { get; set; }
        public int NegocioId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Pin { get; set; } = string.Empty;
        public string Rol { get; set; } = "cajero";
        
        //Datos Laborales
        public DateTime? FechaIngreso { get; set; }
        public string? NumeroSeguroSocial { get; set; }
        public string? Rfc { get; set; }

        //Datos Personales
        public DateTime? FechaNacimiento { get; set; }
        public string? EstadoCivil { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? FotoUrl { get; set; }

        //Contacto de Emergencia
        public string? EmergenciaNombre { get; set; }
        public string? EmergenciaTelefono { get; set; }
        public string? EmergenciaParentesco { get; set; }

        //Privacidad
        public bool PublicoTelefono { get; set; } = false;
        public bool PublicoDireccion { get; set; } = false;
        public bool PublicoEstadoCivil { get; set; } = false;
        public bool PublicoFoto { get; set; } = true;

        public bool Activo { get; set; } = true;
        public DateTime CreadoEn { get; set; } = DateTime.Now;

        //Relaciones
        public Negocio Negocio { get; set; } = new();
        public List<EmpleadoSucursal> EmpleadoSucursales { get; set; } = new();
        public List<Venta> Ventas { get; set; } = new();
        public List<Turno> Turnos { get; set; } = new();
    }
}
