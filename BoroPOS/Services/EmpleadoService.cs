using System;
using System.Collections.Generic;
using System.Text;
using BoroPOS.Models;
using BoroPOS.Data;

namespace BoroPOS.Services
{
    public class EmpleadoService
    {
        private readonly BoroContext _context;

        public EmpleadoService()
        { 
            _context = new BoroContext();
        }

        public Empleado? BuscarPorCredenciales(string empleadoId, string pin)
        {
            return _context.Empleados
                .FirstOrDefault(e => e.EmpleadoId == empleadoId
                                  && e.Pin == pin
                                  && e.Activo == true);
        }
    }
}
