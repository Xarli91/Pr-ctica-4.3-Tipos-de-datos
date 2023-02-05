int num1, num2;

Console.WriteLine("INTRODUCE PRIMER NUMERO:");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("INTRODUCE SEGUNDO NUMERO:");
num2 = int.Parse(Console.ReadLine());

int suma = num1 + num2;
int resta = num1 - num2;
int producto = num1 * num2;
int cociente = num1 / num2;
int residuo = num1 % num2;

Console.WriteLine("PRIMER NUMERO: " + num1);
Console.WriteLine("SEGUNDO NUMERO: " + num2);
Console.WriteLine("LA SUMA ES: " + suma);
Console.WriteLine("LA RESTA ES: " + num1 + " - " + num2 + " = " + resta);
Console.WriteLine("LA MULTIPLICACION ES: " + producto);
Console.WriteLine("LA DIVISION ES: " + cociente);
Console.WriteLine("EL RESIDUO ES: " + residuo);

Console.WriteLine("Pulse una tecla:");
Console.ReadLine();