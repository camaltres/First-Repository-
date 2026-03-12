using Reusable_code;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
var optionsSAS = new List<string> { "p", "n"};
var optionsTemperature = new List<string> { "f", "a" }; 
var optionsStorage = new List<string> { "n", "c", "e", "g"};

//Types of products
List<char> Tp = new List<char> { 'P', 'N', 'p', 'n' };

//Types of conservation 
List<char> Tc = new List<char> { 'F', 'f', 'A', 'a' };

//
List<char> Ma = new List<char> { 'N', 'n', 'C', 'c', 'E', 'e', 'G', 'g' };
do
{
    //Purchase value 
    var CC = ConsoleExtension.GetDecimal($"Costo de Compra ($).....................................................................................: ");

    //Types of products
    var TpVerific = ConsoleExtension.GetChar($"¿Tipo de producto [P]erecedero, [N]o perecedero?........................................................: ");

    //Types of conservation 
    var TcVerific = ConsoleExtension.GetChar($"¿Tipo de conservación [F]rio, [A]mbiente?...............................................................: ");

    //Storage time in days
    var Pc = ConsoleExtension.GetInt($"Periodo de conservación en días.........................................................................: ");

    //Storage period
    var Pa = ConsoleExtension.GetInt($"Periodo de almacenamiento en días.......................................................................: ");

    //Volume in liters
    var Vol = ConsoleExtension.GetInt($"Volumen en litros.......................................................................................: ");

    //
    var MaVerific = ConsoleExtension.GetChar($"Medio de almacenamiento [N]evera, [C]ongelador, [E]stanteria y [G]uacal?................................: ");

    //Storage cost
    decimal CA = 0;

    //Product Depreciation Percentage
    decimal PDP = 0;

    //Exhibition cost
    decimal CE = 0;

    //
    decimal VR_P = 0;

    //The selling price
    decimal VR_V = 0;

    //Variable that increases the type of product
    decimal CCIncrement;

    //Type of products
    if (Tp.Contains(TpVerific))
    {
        //if the type of product is perishable
        if (TpVerific == 'P' || TpVerific == 'p')
        {
            if (Tc.Contains(TcVerific))
            {
                if (TcVerific == 'F' || TcVerific == 'f')
                {
                    if (Pc < 10)
                    {
                        CA = CC * (decimal)0.05;
                    }
                    if (Pc >= 10)
                    {
                        CA = CC * (decimal)0.1;
                    }
                }
                if (TcVerific == 'A' || TcVerific == 'a')
                {
                    if (Pa < 20)
                    {
                        CA = CC * (decimal)0.03;
                    }
                    if (Pa == 20)
                    {
                        CA = CC * (decimal)0.05;
                    }
                    if (Pa > 20)
                    {
                        CA = CC * (decimal)0.1;
                    }
                }
            }
            else
            { 
                return;
            }
        }
        //if the type of product isn't perishable
        if (TpVerific == 'N' || TpVerific == 'n')
        {
            if (Vol >= 50)
            {
                CA = CC * (decimal)0.1;
            }
            if (Vol < 50)
            {
                CA = CC * (decimal)0.2;
            }
        }
    }
    else
    {
        return;
    }

    //Validation of the Product Depreciation Percentage.
    if (Pa < 30)
    {
        PDP = (decimal)0.95;
    }
    if (Pa >= 30)
    {
        PDP = (decimal)0.85;
    }

    //Type of products
    if (Tp.Contains(TpVerific))
    {
        //if the type of product is perishable
        if (TpVerific == 'P' || TpVerific == 'p')
        {
            if (Tc.Contains(TcVerific))
            {
                if (TcVerific == 'F' || TcVerific == 'f')
                {
                    if (Ma.Contains(MaVerific))
                    {
                        if (MaVerific == 'N' || MaVerific == 'n')
                        {
                            CE = CA * 2;
                        }
                        if (MaVerific == 'C' || MaVerific == 'C')
                        {
                            CE = CA;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                return;
            }
    
        }
        //if the type of product isn't perishable
        if (TpVerific == 'N' || TpVerific == 'n')
        {
            if (Ma.Contains(MaVerific))
            {
                if (MaVerific == 'E' || MaVerific == 'E')
                {
                    CE = CA * (decimal)0.05;
                }
                if (MaVerific == 'G' || MaVerific == 'g')
                {
                    CE = CA * (decimal)0.07;
                }
            }
            else
            {
                return;
            }
        }
    }
    else
    {
        return;
    }

    //
    VR_P = (CC + CA + CE) * PDP;

    //Type of products
    if (Tp.Contains(TpVerific))
    {
        //if the type of product is perishable
        if (TpVerific == 'P' || TpVerific == 'p')
        {
            VR_V = VR_P * (decimal)1.4;
        }
        //if the type of product isn't perishable
        if (TpVerific == 'N' || TpVerific == 'n')
        {
            VR_V = VR_P * (decimal)1.2;
        }   
    }
    else
    {
        return;
    }

    Console.WriteLine("***Calculos***");
    Console.WriteLine($"Costo de almacenamiento............: {CA,15:N0}");
    Console.WriteLine($"Porcentaje de depreciación.........: {PDP,15}");
    Console.WriteLine($"Costo de exhibición................: {CE,15:N0}");
    Console.WriteLine($"Valor del Producto.................: {VR_P,15:N0}");
    Console.WriteLine($"Valor de Venta.....................: {VR_V,15:N0}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas Continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));



