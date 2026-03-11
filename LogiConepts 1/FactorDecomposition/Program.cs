using Reusable_code;
using System.Net.Http.Headers;

Console.WriteLine("_____________________________________________");
Console.WriteLine("Programa que descompone un número en factores");
Console.WriteLine("_____________________________________________");

var number = ConsoleExtension.GetInt("Ingrese el número a factorizar.....: ");

//Print the number to be factored with an equal sign
Console.Write($"{number} = ");

//Loop containing a hypothetical prime number and the initial value
for (int i = 2; i <= number; i++)
{
    //variable that keeps track of the divisors of a number
    int divisors = 0;

    //Loop that checks if a number is prime
    for (int a = 1; a <= i; a++)
    {
        if (i % a == 0) 
        {
          divisors++;
        }
    
    }
    ////loop that prints the number of times the prime number can factor the initial number
    if (divisors == 2)
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