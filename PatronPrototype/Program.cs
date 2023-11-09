
using PatronPrototype;

Cliente cliente = new Cliente(1, "Daniel", "Barros Agamez", 22);
Cliente clienteClonado = (Cliente)cliente.Clonar();

Console.WriteLine("======================== Patrón Prototipo =======================\n");
System.Console.WriteLine("Cliente Original");
imprimirCliente(cliente);

System.Console.WriteLine("Cliente Clonado");
imprimirCliente(clienteClonado);

// Modificando el cliente clonado
clienteClonado.Id = 2;
clienteClonado.Nombres = "Cliente clonado";

System.Console.WriteLine("Cliente Clonado Modificado");
imprimirCliente(clienteClonado);


void imprimirCliente(Cliente cliente)
{
    System.Console.WriteLine($"Nombres: {cliente.Id}");
    System.Console.WriteLine($"Nombres: {cliente.Nombres}");
    System.Console.WriteLine($"Nombres: {cliente.Apellidos}");
    System.Console.WriteLine($"Nombres: {cliente.Edad}\n");
}





