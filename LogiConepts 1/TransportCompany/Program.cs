using Reusable_code;

Console.WriteLine("----------------------------------------");
Console.WriteLine("Programa para una compañia de transporte");
Console.WriteLine("----------------------------------------");

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    Console.WriteLine(" ");
    var route = ConsoleExtension.GetInt("Ruta [1],[2],[3],[4]............................: ");
    var trips = ConsoleExtension.GetInt("Numero de viajes................................: ");
    var passengers = ConsoleExtension.GetInt("Número de pasajeros total.......................: ");
    var kg = ConsoleExtension.GetInt("Número de encomiendas de menos de 10kg..........: ");
    var kgPlus = ConsoleExtension.GetInt("Número de encomiendas entre 10kg y menos de 20kg: ");
    var kgPluss = ConsoleExtension.GetInt("Número de encomiendas de más de 20Kg............: ");
    Console.WriteLine(" *** CALCULOS *** ");

    decimal value = 0;
    decimal salary = 0;

    //Commissions based on number of passengers
    switch (route)
    {
        case 1:
        {
            if (passengers <= 50)
            {
               value = 500000 * trips;
            }
            if (passengers >= 51 && passengers <= 100)
            {
               value = (500000 * trips) * (decimal)1.05; 
            }
            if (passengers >= 101 && passengers <= 150)
            {
               value = (500000 * trips) * (decimal)1.06;
            }
            if(passengers >= 151 && passengers <= 200)
            {
               value = (500000 * trips) * (decimal)1.07;
            }
            if (passengers > 200)
            {
               value = (500000 * trips) * (decimal)1.07 + ((passengers - 200) * 50);
            }
            break;
        }
        case 2:
        {
           if (passengers <= 50)
           {
              value = 600000 * trips;
           }
           if (passengers >= 51 && passengers <= 100)
           {
              value = (600000 * trips) * (decimal)1.07;
           }
           if (passengers >= 101 && passengers <= 150)
           {
              value = (600000 * trips) * (decimal)1.08;
           }
           if (passengers >= 151 && passengers <= 200)
           {
              value = (600000 * trips) * (decimal)1.09;
           }
           if (passengers > 200)
           {
              value = (600000 * trips) * (decimal)1.09 + ((passengers - 200) * 60);
           }
           break;
        }
        case 3:
        {
            if (passengers <= 50)
            {
               value = 800000;
            }
            if (passengers >= 51 && passengers <= 100)
            {
               value = 800000 * (decimal)1.1; 
            }
            if (passengers >= 101 && passengers <= 150)
            {
               value = 800000 * (decimal)1.13;
            }
            if(passengers >= 151 && passengers <= 200)
            {
               value = 800000 * (decimal)1.15;
            }
            if (passengers > 200)
            {
               value = 800000 * (decimal)1.15 + ((passengers - 200) * 100);
            }
            break;      
        }
        case 4:
        {
            if (passengers <= 50)
            {
               value = 1000000;
            }
            if (passengers >= 51 && passengers <= 100)
            {
               value = 1000000 * (decimal)1.125; 
            }
            if (passengers >= 101 && passengers <= 150)
            {
               value = 1000000 * (decimal)1.15;
            }
            if(passengers >= 151 && passengers <= 200)
            {
               value = 1000000 * (decimal)1.17;
            }
            if (passengers > 200)
            {
               value = 1000000 * (decimal)1.17 + ((passengers - 200) * 150);
            }
            break;       
        }
        default:
        {
           Console.WriteLine("La ruta que ingreso es incorrecta");
           break;
        }     
    }

    //Parcel service
    switch (route)
    {
        case 1:
        {
           if (kg < 50)
           {
              salary = salary + (kg * 100);                   
           }
           if (kg >= 50 && kg <= 100)
           {
              salary = salary + (kg * 120);                    
           }
           if(kg >= 101 && kg <= 130)
           {
              salary = salary + (kg * 150);
           }
           if(kg >= 130)
           {
              salary = salary + (kg * 160);
           }

           if (kgPlus < 50)
           {
              salary = salary + (kgPlus * 120);                   
           }
           if (kgPlus >= 50 && kgPlus <= 100)
           {
              salary = salary + (kgPlus * 140);                    
           }
           if(kgPlus >= 101 && kgPlus <= 130)
           {
              salary = salary + (kgPlus * 160);
           }
           if(kgPlus >= 130)
           {
              salary = salary + (kgPlus * 180);
           }

           if (kgPluss < 50)
           {
              salary = salary + (kgPluss * 120);                   
           }
           if (kgPluss >= 50 && kgPluss <= 100)
           {
              salary = salary + (kgPluss * 140);                    
           }
           if(kgPluss >= 101 && kgPluss <= 130)
           {
              salary = salary + (kgPluss * 160);
           }
           if(kgPluss >= 130)
           {
              salary = salary + (kgPluss * 180);
           }
           break;  
        }
        case 2:
        {
             if (kg < 50)
           {
              salary = salary + (kg * 100);                   
           }
           if (kg >= 50 && kg <= 100)
           {
              salary = salary + (kg * 120);                    
           }
           if(kg >= 101 && kg <= 130)
           {
              salary = salary + (kg * 150);
           }
           if(kg >= 130)
           {
              salary = salary + (kg * 160);
           }

           if (kgPlus < 50)
           {
              salary = salary + (kgPlus * 120);                   
           }
           if (kgPlus >= 50 && kgPlus <= 100)
           {
              salary = salary + (kgPlus * 140);                    
           }
           if(kgPlus >= 101 && kgPlus <= 130)
           {
              salary = salary + (kgPlus * 160);
           }
           if(kgPlus >= 130)
           {
              salary = salary + (kgPlus * 180);
           }

           if (kgPluss < 50)
           {
              salary = salary + (kgPluss * 120);                   
           }
           if (kgPluss >= 50 && kgPluss <= 100)
           {
              salary = salary + (kgPluss * 140);                    
           }
           if(kgPluss >= 101 && kgPluss <= 130)
           {
              salary = salary + (kgPluss * 160);
           }
           if(kgPluss >= 130)
           {
              salary = salary + (kgPluss * 180);
           }
           break;  
        }
        case 3:
        {
           if (kg < 50)
           {
              salary = salary + (kg * 130);                   
           }
           if (kg >= 50 && kg <= 100)
           {
              salary = salary + (kg * 160);                    
           }
           if(kg >= 101 && kg <= 130)
           {
              salary = salary + (kg * 175);
           }
           if(kg >= 130)
           {
              salary = salary + (kg * 200);
           }

           if (kgPlus < 50)
           {
              salary = salary + (kgPlus * 140);                   
           }
           if (kgPlus >= 50 && kgPlus <= 100)
           {
              salary = salary + (kgPlus * 180);                    
           }
           if(kgPlus >= 101 && kgPlus <= 130)
           {
              salary = salary + (kgPlus * 200);
           }
           if(kgPlus >= 130)
           {
              salary = salary + (kgPlus * 250);
           }

           if (kgPluss < 50)
           {
              salary = salary + (kgPluss * 170);                   
           }
           if (kgPluss >= 50 && kgPluss <= 100)
           {
              salary = salary + (kgPluss * 210);                    
           }
           if(kgPluss >= 101 && kgPluss <= 130)
           {
              salary = salary + (kgPluss * 250);
           }
           if(kgPluss >= 130)
           {
              salary = salary + (kgPluss * 300);
           }

           salary = salary + value;
           break;        
        }
        case 4:
        {
           if (kg < 50)
           {
              salary = salary + (kg * 130);                   
           }
           if (kg >= 50 && kg <= 100)
           {
              salary = salary + (kg * 160);                    
           }
           if(kg >= 101 && kg <= 130)
           {
              salary = salary + (kg * 175);
           }
           if(kg >= 130)
           {
              salary = salary + (kg * 200);
           }

           if (kgPlus < 50)
           {
              salary = salary + (kgPlus * 140);                   
           }
           if (kgPlus >= 50 && kgPlus <= 100)
           {
              salary = salary + (kgPlus * 180);                    
           }
           if(kgPlus >= 101 && kgPlus <= 130)
           {
              salary = salary + (kgPlus * 200);
           }
           if(kgPlus >= 130)
           {
              salary = salary + (kgPlus * 250);
           }

           if (kgPluss < 50)
           {
              salary = salary + (kgPluss * 170);                   
           }
           if (kgPluss >= 50 && kgPluss <= 100)
           {
              salary = salary + (kgPluss * 210);                    
           }
           if(kgPluss >= 101 && kgPluss <= 130)
           {
              salary = salary + (kgPluss * 250);
           }
           if(kgPluss >= 130)
           {
              salary = salary + (kg * 300);
           }
           salary = salary + value;
           break;       
        }
    }

    Console.WriteLine($"Ingresos por Pasajeros................: {value,15:C0}");
    Console.WriteLine($"Ingresos por Encomiendas..............: {salary,15:C0}");
    Console.WriteLine("                                      :---------------- ");





    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas Continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));