
Console.WriteLine("______________________________________________");
Console.WriteLine("Programa para saber si 2 números son múltiplos");
Console.WriteLine("______________________________________________");

Console.WriteLine("Ingrese el primer número");
var number1 = Console.ReadLine();
if (!double.TryParse(number1, out double result1))
{
    Console.WriteLine("El valor ingresado no es un dato válido.");
    return;
}

// I believe the part of the document that says the number 3 is a multiple of 45 is misspelled. I think the number 45 is a multiple of 3. I apologize if I caused any inconvenience.
Console.WriteLine("Ingrese el segundo número");
var number2 = Console.ReadLine();
if (!double.TryParse(number2, out double result2))
{
    Console.WriteLine("El valor ingresado no es un dato válido.");
    return;
}

if (result1 % result2 == 0) 
{
    Console.WriteLine($"El número: {result1} es múltiplo de {result2}");
}
else
{
    Console.WriteLine($"El número: {result1} no es múltiplo de {result2}");
}