using Reusable_code;

Console.WriteLine("---------------------------------");
Console.WriteLine("Programa para evaluar el subsidio");
Console.WriteLine("_________________________________");

public class SubProgram()
{
    public static void GetSubsidy(int message)
    {
        var subsidy = ConsoleExtension.GetInt("Ingrese el estrato que posee: ");
        decimal value;
        if (subsidy == 1)
        {
            value = 200000;
            Console.Write($"Valor del subsidio {value:C2}");

        }
        else if (subsidy == 2)
        {

            value = 100000;
            Console.Write($"Valor del subsidio {value:C2}");

        }
        else
        { 
            Console.Write("Valor de estrato incorrecto");

        }

    }


}

  


