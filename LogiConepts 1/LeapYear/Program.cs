Console.WriteLine("______________________________________________");
Console.WriteLine("Programa para saber si un año es bisiesto o no");
Console.WriteLine("______________________________________________");

Console.WriteLine("Ingrese el año");
var year = Console.ReadLine();
if (!double.TryParse(year, out double yeardouble))
{
    Console.WriteLine("Ingre un dato valido");
    return;
}

if ((yeardouble % 4 == 0) && (yeardouble % 100 != 0))
{
    Console.WriteLine($"El año: {yeardouble} si es bisisesto");
}
else if ((yeardouble % 100 == 0) && (yeardouble % 400 != 0))
{
    Console.WriteLine($"El año: {yeardouble} no es bisiesto");
}
else if ((yeardouble % 100 == 0) && (yeardouble % 400 == 0))
{
    Console.WriteLine($"El año: {yeardouble} si es bisiesto");
}
else
{
    Console.WriteLine($"El año: {yeardouble} no es bisiesto");
}
