using Reusable_code;

var answer = string.Empty;
var options = new List<string> { "s", "n" }; // Fixed variable name

do
{
    var number = ConsoleExtension.GetInt("Ingrese un numero entero");

    if (number % 2 == 0)
    {
        Console.WriteLine($"El numero {number}, es par");
    }
    else
    {
        Console.WriteLine($"El numero {number}, es impar");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i, [N]O?;", options); 
    }
    while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase))); 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)); 

Console.WriteLine("El programa termino");