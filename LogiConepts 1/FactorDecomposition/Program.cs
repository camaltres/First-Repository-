using Reusable_code;
using System.Net.Http.Headers;

Console.WriteLine("_____________________________________________");
Console.WriteLine("Programa que descompone un número en factores");
Console.WriteLine("_____________________________________________");

var number = ConsoleExtension.GetInt("Ingrese el numero a factorizar.....: ");

Console.Write($"{number} = ");
for (int i = 2; i <= number; i++)
{
    int dividor = 0;
    for (int a = 1; a <= i; a++)
    {
        if (i % a == 0)
        { 
          dividor++;
        }
    
    }
    if (dividor == 2)
    {
        while (number % i == 0)
        {
            Console.Write($" {i} ");
            number = number / i;
            if (number / i > 0)
            {
                Console.Write(" x ");
            }
        }
    }


}