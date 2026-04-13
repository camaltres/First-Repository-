using Reusable_code;

Console.WriteLine("----------------------------------------");
Console.WriteLine("Programa para una compañia de transporte");
Console.WriteLine("----------------------------------------");

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var routeOptions = new List<string> { "1", "2", "3", "4" };
    var route = string.Empty;
    do
    {
        route = ConsoleExtension.GetValidOptions("Ruta del bus [1] [2] [3] [4]........: ", routeOptions);
    } while (!routeOptions.Any(x => x == route));

    var trips = ConsoleExtension.GetInt("Número de viajes..........................................: ");
    var passanger = ConsoleExtension.GetInt("Número de pasajeros total.............................: ");
    var parcels10 = ConsoleExtension.GetInt("Número de encomiendas de menos de 10Kg................: ");
    var parcels15 = ConsoleExtension.GetInt("Número de encomiendas entre 10Kg y menos de 20Kg......: ");
    var parcels20 = ConsoleExtension.GetInt("Número de encomiendas de más de 20Kg..................: ");

    //Calculations
    var incomePassanger = GetIncomePassanger(route, passanger, trips);
    var incomeParcels = GetIncomeParcels(parcels10, parcels15, parcels20, route);
    var incomes = incomePassanger + incomeParcels;
    var valueHelper = GetValueHelper(incomes);
    var valueAssurrace = GetValueAssurrace(incomes);
    var fuelValue = GetFuel(route, trips);

    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas Continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase))) ;
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal GetIncomePassanger(string? route, int passanger, int trips)
{
    decimal value;
    switch (route)
    {
        case "1":
        
          value = 500000m * trips;
          if(passanger <= 50) return value;
          if(passanger <= 100) return value * 1.05m;
          if(passanger <= 150) return value * 1.06m;
          if(passanger <= 200) return value * 1.07m;
          return value * 1.07m + (passanger - 200) * 50m;
        
        case "2": 
        
          value = 600000m * trips;
          if(passanger <= 50) return value;
          if(passanger <= 100) return value * 1.07m;
          if(passanger <= 150) return value * 1.08m;
          if(passanger <= 200) return value * 1.09m;
          return value * 1.09m + (passanger - 200) * 60m;
        
        case "3":
        
          value = 800000m * trips;
          if(passanger <= 50) return value;
          if(passanger <= 100) return value * 1.1m;
          if(passanger <= 150) return value * 1.13m;
          if(passanger <= 200) return value * 1.15m;
          return value * 1.15m + (passanger - 200) * 100m;
        
        case "4":
        
          value = 1000000m * trips;
          if(passanger <= 50) return value;
          if(passanger <= 100) return value * 1.125m;
          if(passanger <= 150) return value * 1.15m;
          if(passanger <= 200) return value * 1.17m;
          return value * 1.17m + (passanger - 200) * 150m;

        default:
            return 0;
    }
}

decimal GetIncomeParcels(int parcels10, int parcels15, int parcels20, string? route)
{
    decimal value = 0;
    switch (route)
    {
        case "1":
        case "2":
        
          if(parcels10 <= 50) value += value + parcels10 * 100;
          else if(parcels10 <= 100) value += value + parcels10 * 120;
          else if(parcels10 <= 130) value += value + parcels10 * 150;
          else value += value + parcels10 * 160;

          var parcelsGreathers = parcels15 + parcels20;
          if(parcelsGreathers <= 50) value += parcelsGreathers * 120;
          else if (parcelsGreathers <= 100) value += parcelsGreathers * 140;
          else if (parcelsGreathers <= 130) value += parcelsGreathers * 160;
          else value += parcelsGreathers * 180;

          return value;

        default:

          if(parcels10 <= 50) value += value + parcels10 * 130;
          else if(parcels10 <= 100) value += value + parcels10 * 160;
          else if(parcels10 <= 130) value += value + parcels10 * 175;
          else value += value + parcels10 * 200;

          if(parcels15 <= 50) value += value + parcels20 * 140;
          else if(parcels15 <= 100) value += value + parcels20 * 180;
          else if(parcels15 <= 130) value += value + parcels20 * 200;
          else value += value + parcels15 * 250;

          if(parcels20 <= 50) value += value + parcels20 * 170;
          else if(parcels20 <= 100) value += value + parcels20 * 210;
          else if(parcels20 <= 130) value += value + parcels20 * 250;
          else value += value + parcels20 * 300;

          return value;
 
    }

}

decimal GetValueHelper(decimal incomes)
{
    if (incomes < 1000000) return incomes * 0.05m;
    if (incomes < 2000000) return incomes * 0.08m;
    if(incomes < 4000000) return incomes * 0.10m;
    return incomes * 0.13m;
}

decimal GetValueAssurrace(decimal incomes)
{
    if (incomes <= 1000000) return incomes * 0.03m;
    if (incomes <= 2000000) return incomes * 0.04m;
    if (incomes <= 4000000) return incomes * 0.6m;
    return incomes * 0.09m;
}

object GetFuel(string? route, int trips)
{
    float km;

    switch (route)
    {
        case "1":
            
            km = trips * 150;
            break;
       
        case "2":

            km = trips * 167;
            break ;

        case "3":

            km = trips * 184;
            break;
        default:

            km = trips * 203;
            break;     
    }

    float gal = 8860 * (km / 39);
    decimal subsidy = (decimal)gal * 0.25m;
    decimal subtraction = (decimal)gal - subsidy;
    return subtraction;
}