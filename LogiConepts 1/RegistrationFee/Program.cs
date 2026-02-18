using Reusable_code;

Console.WriteLine("---------------------------------------");
Console.WriteLine("Programa para el valor de una matricula");
Console.WriteLine("_______________________________________");

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var credits = ConsoleExtension.GetInt("Ingrese la cantidad de creditos: ");
    var valueCredits = ConsoleExtension.GetDecimal("Valor Crédito: ");
    var stratum = ConsoleExtension.GetInt("Estrato del estudiante: ");
  
    decimal x;
    float discount;
    float regularPrice;
    float difference;
    float increase;
    float addition;
    float value;

    if (stratum == 1)
    {
        if (credits <= 20)
        {
            discount = 0.8f;
            regularPrice = (float)(credits * valueCredits);
            value = regularPrice - (regularPrice * discount);
            Console.WriteLine($"Costo de la matricula: {value:C2}");
        }
        else
        {
            discount = 0.8f;
            regularPrice = (float)(20 * valueCredits);
            difference = credits - 20;
            increase = (float)(valueCredits * 2) * difference;
            addition = increase + regularPrice;
            value = addition - (addition * discount);
            Console.WriteLine($"Costo de la matricula: {value:C2}");
        }


    }
    else if (stratum == 2)
    {
        if (credits <= 20)
        {
            discount = 0.5f;
            regularPrice = (float)(credits * valueCredits);
            value = regularPrice - (regularPrice * discount);
            Console.WriteLine($"Costo de la matricula: {value:C2}");
        }
        else
        {
            discount = 0.5f;
            regularPrice = (float)(20 * valueCredits);
            difference = credits - 20;
            increase = (float)(valueCredits * 2) * difference;
            addition = increase + regularPrice;
            value = addition - (addition * discount);
            Console.WriteLine($"Costo de la matricula: {value:C2}");
        }



    }
    else if (stratum == 3)
    {
        if (credits <= 20)
        {
            discount = 0.3f;
            regularPrice = (float)(credits * valueCredits);
            value = regularPrice - (regularPrice * discount);
            Console.WriteLine($"Costo de la matricula: {value:C2}");
        }
        else
        {
            discount = 0.3f;
            regularPrice = (float)(20 * valueCredits);
            difference = credits - 20;
            increase = (float)(valueCredits * 2) * difference;
            addition = increase + regularPrice;
            value = addition - (addition * discount);
            Console.WriteLine($"Costo de la matricula: {value:C2}");
        }
    }
    else
    {

        Console.WriteLine("Estrato no permitido");
        
    }

    
    decimal value1;
    if (stratum == 1)
    {
        value1 = 200000;
        Console.WriteLine($"Valor del subsidio {value1:C2}");

    }
    else if (stratum == 2)
    {

        value1 = 100000;
        Console.WriteLine($"Valor del subsidio {value1:C2}");

    }
    else
    {
        Console.WriteLine("Valor de estrato incorrecto");

    }


    do
    {
      answer = ConsoleExtension.GetValidOptions("¿Deseas Continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));



