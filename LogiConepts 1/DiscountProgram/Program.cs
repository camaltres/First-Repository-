
using Reusable_code;

Console.WriteLine("______________________");
Console.WriteLine("Programa de descuentos");
Console.WriteLine("______________________");


var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{

    var numberDesk = ConsoleExtension.GetInt("Ingrese la cantidad de escritorios comprados: ");
    var x = 650000 * numberDesk;
    double discount;

    if (numberDesk < 5)
    {
        discount = 0.1;

    }
    else if ((numberDesk >= 5) && (numberDesk < 10))
    {
        discount = 0.2;

    }
    else
    {
        discount = 0.4;
 
    }

    var value = x - (x * discount);
    Console.WriteLine($"El valor a pagar es: {value:C2} ");
    do
    {
      answer = ConsoleExtension.GetValidOptions("¿Deseas Continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));