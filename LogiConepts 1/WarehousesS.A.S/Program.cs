using Reusable_code;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
var optionsSAS = new List<string> { "p", "n"};
var optionsTemperature = new List<string> { "f", "a" }; 
var optionsStorage = new List<string> { "n", "c", "e", "g"};

do
{
    var CC = ConsoleExtension.GetDecimal("Costo de Compra ($).....................................................................................: ");

    do
    {
       answer = ConsoleExtension.GetValidOptionsSAS("¿Tipo de producto [P]erecedero, [N]o perecedero?.............................................: ", optionsSAS);
    } while (!optionsSAS.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

    do
    {
        answer = ConsoleExtension.GetValidOptionsSAS("¿Tipo de conservación [F]rio, [A]mbiente?...................................................: ", optionsTemperature);
    } while (!optionsTemperature.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

    var Pc = ConsoleExtension.GetInt("Periodo de conservación en días\t.............................................................................: ");
    var Pa = ConsoleExtension.GetInt("Periodo de almacenamiento en días\t...........................................................................: ");
    var Vol = ConsoleExtension.GetFloat("Volumen en litros\t........................................................................................: ");

    do
    {
        answer = ConsoleExtension.GetValidOptionsSAS("Medio de almacenamiento [N]evera, [C]ongelador, [E]stanteria y [G]uacal?....................: ", optionsStorage);
    } while (!optionsStorage.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
















    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas Continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));



