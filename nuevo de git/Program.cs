Console.WriteLine("Hello, World!");
Console.WriteLine("Hola Bay");



string producto = "";
double precio = 0.0;
int cantidad = 0;


Console.WriteLine("ingrese su producto");

producto = Console.ReadLine();


Console.WriteLine("ingrese el precio");
precio = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad");
cantidad = int.Parse(Console.ReadLine());

Console.WriteLine("el producto {0} tiene una inversion de {1}" ,producto, (double)precio*cantidad);
Console.ReadKey(); 
