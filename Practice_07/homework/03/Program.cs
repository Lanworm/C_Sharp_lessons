// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



double[,] GenerateMAtrix(int rows, int cols)
{

    Random rand = new Random();
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void PrintArray(double[] arr)
{
    System.Console.WriteLine(string.Join("\t", arr)+" <--Среднее арифметическое столбцов" );
}

double[] GetAverage(double[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum+=matrix[j,i];
        }
        result[i]=Math.Round(sum/matrix.GetLength(0),2);
    }
    return result;
}

Random rand = new Random();
int rows = rand.Next(2, 4);
int cols = rand.Next(2, 4);
var myMatrix = GenerateMAtrix(rows, cols);
System.Console.WriteLine($"Была сгенерирована матрица {rows}x{cols}");
PrintMatrix(myMatrix);
PrintArray(GetAverage(myMatrix));



