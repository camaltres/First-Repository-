
//User interface.
Console.WriteLine("_______________________________");
Console.WriteLine("Programa para ordenar 3 números");
Console.WriteLine("_______________________________");

//This part of the code is important because it validates that the user has entered correct data.
Console.WriteLine("Ingrese el primer número");
var number1 = Console.ReadLine();
if (!int.TryParse(number1, out int result1)) 
{ 
    Console.WriteLine("El valor ingresado no es un número válido."); 
    return;
}

Console.WriteLine("Ingrese el segundo número");
var number2 = Console.ReadLine();
if (!int.TryParse(number2, out int result2))
{
    Console.WriteLine("El valor ingresado no es un número válido.");
    return;
}

Console.WriteLine("Ingrese el tercero número");
var number3 = Console.ReadLine();
if (!int.TryParse(number3, out int result3))
{
    Console.WriteLine("El valor ingresado no es un número válido.");
    return;
}

// This code is not the most efficient way to find the largest number among three numbers, but it works correctly.
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
else if ((result1 == result2) && (result2 > result3))
{
    Console.WriteLine($"El número mayor es: {result1}");
}
else if ((result3 == result2) && (result2 > result1))
{ 
    Console.WriteLine($"El número mayor es: {result2}");
}
else if((result3 == result1) && (result1 > result2))
{
    Console.WriteLine($"El número mayor es: {result1}");
}
else
{
    Console.WriteLine($"El número mayor es: {result1}");
}


// This code is not the most efficient way to find the middle number among three numbers, but it works correctly.
if ((result1 > result2) && (result1 < result3) || (result1 > result3) && (result1 < result2))
{
    Console.WriteLine($"El numero del medio es: {result1}");
}
else if ((result2 > result3) && (result2 < result1) || (result2 > result1) && (result2 < result3))
{
    Console.WriteLine($"El numero del medio es: {result2}");
}
else if ((result3 > result2) && (result3 < result1) || (result3 > result1) && (result3 < result2))
{
    Console.WriteLine($"El numero del medio es: {result3}");
}
else
{
    Console.WriteLine($"El número del medio es: {result2}");
}

// This code is not the most efficient way to find the smallest number among three numbers, but it works correctly.
if ((result1 < result2) && (result1 < result3))
{
    Console.WriteLine($"El número menor es: {result1}");
}
else if ((result2 < result1) && (result2 < result3))
{
    Console.WriteLine($"El número menor es: {result2}");
}
else if ((result3 < result1) && (result3 < result2))
{
    Console.WriteLine($"El número menor es: {result3}");
}
else if ((result1 == result2) && (result2 < result3))
{
    Console.WriteLine($"El número menor es: {result1}");
}
else if ((result3 == result2) && (result2 < result1))
{
    Console.WriteLine($"El número menor es: {result2}");
}
else if ((result3 == result1) && (result1 < result2))
{
    Console.WriteLine($"El número menor es: {result1}");
}
else
{
    Console.WriteLine($"El número menor es: {result1}");
}

