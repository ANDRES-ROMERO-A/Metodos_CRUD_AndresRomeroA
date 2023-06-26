using Metodos_CRUD_AndresRomeroA.Models;

class Program
{
    static void Main(string[] args)
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        // Crear un nuevo cliente
        Cliente nuevoCliente = new Cliente
        {
            Nombre = "Andres",
            Apellido = "Romero",
            Direccion = "Km 8.5Via a Daule",
            Telefono = "0969631616",
            FechaNacimiento = new DateTime(2001, 2, 14),
            Estado = "Activo"
        };
        clienteRepository.Guardar(nuevoCliente);

        // Consultar un cliente por su ID
        int clienteId = 1;
        Cliente clienteConsultado = clienteRepository.Consultar(clienteId);
        if (clienteConsultado != null)
        {
            Console.WriteLine($"Cliente consultado: {clienteConsultado.Nombre} {clienteConsultado.Apellido}");
        }
        else
        {
            Console.WriteLine("No se encontró ningún cliente con el ID especificado.");
        }

        // Modificar un cliente existente
        Cliente clienteModificado = new Cliente
        {
            Id = clienteId,
            Nombre = "Cristhian",
            Apellido = "Romero",
            Direccion = "Coop Colinas al sol",
            Telefono = "0909090909",
            FechaNacimiento = new DateTime(1994, 4, 28),
            Estado = "Inactivo"
        };
        clienteRepository.Modificar(clienteModificado);

        // Eliminar un cliente
        clienteRepository.Eliminar(clienteId);

        Console.ReadLine();
    }
}
