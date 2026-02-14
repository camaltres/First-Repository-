Console.WriteLine("__________________________________________________________");
Console.WriteLine("Programa para encontrar el número mayor entre 3 números");
Console.WriteLine("__________________________________________________________");


Console.WriteLine("Ingrese el primer número");
var number1 = Console.ReadLine();
if (!int.TryParse(number1, out int result1))
{
    return;
}


Console.WriteLine("Ingrese el Segundo número");
var number2 = Console.ReadLine();
if (!int.TryParse(number2, out int result2))
{
    return;
}

Console.WriteLine("Ingrese el Tercer número");
var number3 = Console.ReadLine();
if (!int.TryParse(number3, out int result3))
{
    return;
}


if ((result1 >= 0) && (result2 >= 0) && (result3 >= 0))
{
    if ((result1 > result2) && (result1 > result3))
    {
        Console.WriteLine($"El número mayor es: {result1}");
    }
    else if ((result2 > result1) && (result2 > result3))
    {
        Console.WriteLine($"El número mayor es: {result2}");
    }
    else if ((result3 > result1) && (result3 > result2))
    {
        Console.WriteLine($"El número mayor es: {result3}");
    }
    else
    {
        Console.WriteLine("Los 3 números son iguales");
    }
}
else 
{
    Console.WriteLine("Escriba un numero entero positivo mayor o igual a 0");
}

