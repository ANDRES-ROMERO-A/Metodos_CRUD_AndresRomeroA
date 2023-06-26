namespace Metodos_CRUD_AndresRomeroA.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ClienteRepository
    {
        private List<Cliente> clientes;

        public ClienteRepository()
        {
            clientes = new List<Cliente>();
        }

        public void Guardar(Cliente cliente)
        {
            // Generar el ID para el cliente
            cliente.Id = clientes.Count + 1;

            clientes.Add(cliente);
            Console.WriteLine("Cliente guardado con éxito.");
        }

        public Cliente Consultar(int id)
        {
            return clientes.FirstOrDefault(c => c.Id == id);
        }

        public void Modificar(Cliente clienteModificado)
        {
            Cliente clienteExistente = clientes.FirstOrDefault(c => c.Id == clienteModificado.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nombre = clienteModificado.Nombre;
                clienteExistente.Apellido = clienteModificado.Apellido;
                clienteExistente.Direccion = clienteModificado.Direccion;
                clienteExistente.Telefono = clienteModificado.Telefono;
                clienteExistente.FechaNacimiento = clienteModificado.FechaNacimiento;
                clienteExistente.Estado = clienteModificado.Estado;
                Console.WriteLine("Cliente modificado con éxito.");
            }
            else
            {
                Console.WriteLine("No se encontró ningún cliente con el ID especificado.");
            }
        }

        public void Eliminar(int id)
        {
            Cliente clienteExistente = clientes.FirstOrDefault(c => c.Id == id);
            if (clienteExistente != null)
            {
                clientes.Remove(clienteExistente);
                Console.WriteLine("Cliente eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("No se encontró ningún cliente con el ID especificado.");
            }
        }
    }
}
