using Reusable_code;
/*
Console.WriteLine("---------------------------------");
Console.WriteLine("Programa para una nomina sencilla");
Console.WriteLine("_________________________________");

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var name = ConsoleExtension.GetString("Ingrese su nombre: ");

    Console.Write("Ingrese el número de horas trabajadas: ");
    var hours = Console.ReadLine();
    if (!float.TryParse(hours, out float hoursInt))
    {
        Console.WriteLine("El dato que esta ingresando no es el correcto");
        return;
    }

    Console.Write("Ingrese su salario básico por horas: $");
    var basicsalary = Console.ReadLine();
    if (!float.TryParse(basicsalary, out float basicInt))
    {
        Console.WriteLine("El dato que esta ingresando no es el correcto");
        return;
    }

    Console.Write("Ingrese valor salario minimo mensual: $");
    var salaryMinimun = Console.ReadLine();
    if (!float.TryParse(salaryMinimun, out float salaryMinimundouble))
    {
        Console.WriteLine("El dato que esta ingresando no es el correcto");
        return;
    }

    var a = (float)hoursInt * basicInt;
    if (a > salaryMinimundouble)
    {
        Console.WriteLine($"Nombre: {name}");

        Console.WriteLine($"Salario mensual: {a}");
    }
    else
    {
        Console.WriteLine($"Nombre: {name}");
        Console.WriteLine($"Salario: {salaryMinimundouble}");
    }

    do
    {
       answer = ConsoleExtension.GetValidOptions("¿Deseas Continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

*/

// Updete and improved code

Console.WriteLine("---------------------------------");
Console.WriteLine("Programa para una nomina sencilla");
Console.WriteLine("_________________________________");

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var name = ConsoleExtension.GetString("Ingrese su nombre: ");
    var hours = ConsoleExtension.GetFloat("Ingrese el número de horas trabajadas: ");
    var basicsalary = ConsoleExtension.GetDecimal("Ingrese su salario básico por horas: ");
    var salaryMinimun = ConsoleExtension.GetDecimal("Ingrese valor salario mínimo mensual: ");

    var x = (decimal)hours * basicsalary;
    if (x > salaryMinimun)
    {
        Console.WriteLine($"Nombre: {name}");
        Console.WriteLine($"Salario mensual: {x:C2}"); 
    }
    else
    {  
        Console.WriteLine($"Nombre: {name}");
        Console.WriteLine($"Salario: {salaryMinimun:C2}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas Continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));