using Reusable_code;

Console.WriteLine("________________________");
Console.WriteLine("Programa para una Matriz");
Console.WriteLine("________________________");

var order = ConsoleExtension.GetInt("Ingrese el orden de la matriz: ");
int[,] matrix = new int[order,order];

//This loop fills the matrix with the following formula (i + 1) - j
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = (i + 1) - j;
    }
}
//I created these variables to find the maximum, minimum, and sum of the matrix
int x = 0;
int y = 0;
int z = 0;

//This loop prints the position of a number found in the array, in addition to performing other operations.
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        Console.Write($"{matrix[i,j].ToString()}\t");

        //Each time j is equal to the number being subtracted, a line break is created.
        if (j == (order - 1))
        {
            Console.WriteLine("\n");
        }
        //Take the largest number
        if (x < matrix[i, j])
        { 
            x = matrix[i, j];
        }
        //Take the smallest number
        if (y > matrix[i, j])
        {
            y = matrix[i, j];
        }
        //addition
        z = z + matrix[i, j];
    }

}
//Print the values
Console.WriteLine($"La suma es: {z}");
Console.WriteLine($"El número mayor es: {x}");
Console.WriteLine($"El numero menor es: {y}");