using Reusable_code;

Console.WriteLine("----------------------------------------");
Console.WriteLine("Programa para una compañia de transporte");
Console.WriteLine("----------------------------------------");

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    Console.WriteLine(" ");
    var route = ConsoleExtension.GetInt("Ruta [1],[2],[3],[4].............................: ");
    var trips = ConsoleExtension.GetInt("Numero de viajes.................................: ");
    var passengers = ConsoleExtension.GetInt("Número de pasajeros total...................: ");
    var kg = ConsoleExtension.GetInt("Número de encomiendas de menos de 10kg..............: ");
    var kgPlus = ConsoleExtension.GetInt("Número de encomiendas entre 10kg y menos de 20kg: ");
    var kgPluss = ConsoleExtension.GetInt("Número de encomiendas de más de 20Kg...........: ");
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
               value = 500000;
            }
            if (passengers >= 51 && passengers <= 100)
            {
               value = 500000 * (decimal)1.05; 
            }
            if (passengers >= 101 && passengers <= 150)
            {
               value = 500000 * (decimal)1.06;
            }
            if(passengers >= 151 && passengers <= 200)
            {
               value = 500000 * (decimal)1.07;
            }
            if (passengers > 200)
            {
               value = 500000 * (decimal)1.07 + ((passengers - 200) * 50);
            }
            break;
        }
        case 2:
        {
           if (passengers <= 50)
           {
              value = 600000;
           }
           if (passengers >= 51 && passengers <= 100)
           {
              value = 600000 * (decimal)1.07;
           }
           if (passengers >= 101 && passengers <= 150)
           {
              value = 600000 * (decimal)1.08;
           }
           if (passengers >= 151 && passengers <= 200)
           {
              value = 600000 * (decimal)1.09;
           }
           if (passengers > 200)
           {
              value = 600000 * (decimal)1.09 + ((passengers - 200) * 60);
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
              salary = salary * 100;                   
           }
           if (kg >= 50 && kg <= 100)
           {
              salary = salary + 120;                    
           }
           if(kg >= 101 && kg <= 130)
           {
              salary = salary + 150;
           }
           if(kg >= 130)
           {
              salary = salary + 160;
           }

           if (kgPlus < 50)
           {
              salary = salary + 120;                   
           }
           if (kgPlus >= 50 && kg <= 100)
           {
              salary = salary + 140;                    
           }
           if(kgPlus >= 101 && kg <= 130)
           {
              salary = salary + 160;
           }
           if(kgPlus >= 130)
           {
              salary = salary + 180;
           }
           salary = salary + value;
           break;  
        }
        case 2:
        {
           if (kg < 50)
           {
              salary = salary + 100;                   
           }
           if (kg >= 50 && kg <= 100)
           {
              salary = salary + 120;                    
           }
           if(kg >= 101 && kg <= 130)
           {
              salary = salary + 150;
           }
           if(kg >= 130)
           {
              salary = salary + 160;
           }
           //kgPlus 
           if (kgPlus < 50)
           {
              salary = salary + 120;                   
           }
           if (kgPlus >= 50 && kg <= 100)
           {
              salary = salary + 140;                    
           }
           if(kgPlus >= 101 && kg <= 130)
           {
              salary = salary + 160;
           }
           if(kgPlus >= 130)
           {
              salary = salary + 180;
           }
           salary = salary + value;
           break;       
        }
        case 3:
        {
           if (kg < 50)
           {
              salary = salary + 130;                   
           }
           if (kg >= 50 && kg <= 100)
           {
              salary = salary + 160;                    
           }
           if(kg >= 101 && kg <= 130)
           {
              salary = salary + 175;
           }
           if(kg >= 130)
           {
              salary = salary + 200;
           }

           if (kgPlus < 50)
           {
              salary = salary + 140;                   
           }
           if (kgPlus >= 50 && kg <= 100)
           {
              salary = salary + 180;                    
           }
           if(kgPlus >= 101 && kg <= 130)
           {
              salary = salary + 200;
           }
           if(kgPlus >= 130)
           {
              salary = salary + 250;
           }

           if (kgPluss < 50)
           {
              salary = salary + 170;                   
           }
           if (kgPluss >= 50 && kg <= 100)
           {
              salary = salary + 210;                    
           }
           if(kgPluss >= 101 && kg <= 130)
           {
              salary = salary + 250;
           }
           if(kgPluss >= 130)
           {
              salary = salary + 300;
           }

           salary = salary + value;
           break;        
        }
        case 4:
        {
           if (kg < 50)
           {
              salary = salary + 130;                   
           }
           if (kg >= 50 && kg <= 100)
           {
              salary = salary + 160;                    
           }
           if(kg >= 101 && kg <= 130)
           {
              salary = salary + 175;
           }
           if(kg >= 130)
           {
              salary = salary + 200;
           }

           if (kgPlus < 50)
           {
              salary = salary + 140;                   
           }
           if (kgPlus >= 50 && kg <= 100)
           {
              salary = salary + 180;                    
           }
           if(kgPlus >= 101 && kg <= 130)
           {
              salary = salary + 200;
           }
           if(kgPlus >= 130)
           {
              salary = salary + 250;
           }

           if (kgPluss < 50)
           {
              salary = salary + 170;                   
           }
           if (kgPluss >= 50 && kg <= 100)
           {
              salary = salary + 210;                    
           }
           if(kgPluss >= 101 && kg <= 130)
           {
              salary = salary + 250;
           }
           if(kgPluss >= 130)
           {
              salary = salary + 300;
           }
           salary = salary + value;
           break;       
        }
    }
  






    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas Continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));