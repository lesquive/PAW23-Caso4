using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixRepairAPI.Models;

namespace AutoFixRepairAPI.Services
{
    public class ClienteServices
    {
        private readonly AutoFixDbContext _context;

        public ClienteServices(AutoFixDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Cliente> ObtenerTodosLosClientes()
        {
            return _context.Clientes.ToList();
        }

        public void CrearCliente(Cliente nuevoCliente)
        {
            _context.Clientes.Add(nuevoCliente);
            _context.SaveChanges();
        }

        public void ActualizarCliente(Cliente clienteActualizado)
        {
            _context.Clientes.Update(clienteActualizado);
            _context.SaveChanges();
        }

        public Cliente ObtenerClientePorId(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.ClienteId == id);
        }
    }
}
