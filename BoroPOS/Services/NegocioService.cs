using BoroPOS.Data;
using BoroPOS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoroPOS.Services
{
    public class NegocioService
    {
        private readonly BoroContext _context;

        public NegocioService() 
        {
            _context = new BoroContext(); 
        }

        public List<Negocio> ObtenerTodos()
        { 
            return _context.Negocios.ToList();
        }
    }
}
