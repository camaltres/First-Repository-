namespace Reusable_code
{
    public static class ConsoleExtension
    {
        //This method is used to obtain an integer
        public static int GetInt(string message)
        { 
            Console.WriteLine(message);
            var numberString = Console.ReadLine();
            if (int.TryParse(numberString, out int numberInt))
            {
                return numberInt;
            }

            return 0;
        }


        //This method is used to obtain a string
        public static string? GetString(string message)
        {
            Console.Write(message);
            var text = Console.ReadLine();
            return text;
        }


        //This method is used to obtain a float
        public static float GetFloat(string message)
        {
            Console.Write(message);
            var numberText = Console.ReadLine();
            if (float.TryParse(numberText, out float numberFloat))
            { 
                return numberFloat;
            }
            else
            {
                return 0;
            }

        }

        //This method is used to obtain a decimal and helps us represent money.
        public static decimal GetDecimal(string message)
        {

            Console.Write(message);
            var numberText = Console.ReadLine();
            if (decimal.TryParse(numberText, out decimal numberDecimal))
            {
                return numberDecimal;
            }
            else
            {
                return 0;
            }
        }

        public static string? GetValidOptions(string message, List<string> options)
        {
            Console.Write(message);
            var answer = Console.ReadLine();
            if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
            {
                return answer;
            }
            return null;
        }














    }
}