
using PatronPrototype;

Cliente cliente = new Cliente(1, "Daniel", "Barros Agamez", 22, new List<int> { 1, 2, 3, 4 });
Cliente clienteClonado = (Cliente)cliente.Clonar();

Console.WriteLine("======================== Patrón Prototipo =======================\n");
System.Console.WriteLine("Cliente Original");
imprimirCliente(cliente);

System.Console.WriteLine("Cliente Clonado");
imprimirCliente(clienteClonado);

// Modificando el cliente clonado
clienteClonado.Id = 2;
clienteClonado.Nombres = "Cliente clonado";
clienteClonado.Telefonos.Add(1000);

System.Console.WriteLine("Cliente Clonado Modificado");
imprimirCliente(clienteClonado);

Console.WriteLine("Cliente Original");
imprimirCliente(cliente);


void imprimirCliente(Cliente cliente)
{
    System.Console.WriteLine($"Nombres: {cliente.Id}");
    System.Console.WriteLine($"Nombres: {cliente.Nombres}");
    System.Console.WriteLine($"Nombres: {cliente.Apellidos}");
    System.Console.WriteLine($"Nombres: {cliente.Edad}");
    Console.WriteLine($"Teléfonos: {string.Join(",", cliente.Telefonos)} {Environment.NewLine}");
}





