// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}



int[,] GenerateMAtrix(int rows, int cols)
{

    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

int row = ReadInt("Введите строку :");
int col = ReadInt("Введите столбец :");
Random rand = new Random();
int rows = rand.Next(2, 10);
int cols = rand.Next(2, 10);
var myMatrix = GenerateMAtrix(rows, cols);
System.Console.WriteLine($"Была сгенерирована матрица {rows}x{cols}");
PrintMatrix(myMatrix);

if (row > rows || col > cols)
{
    System.Console.WriteLine("Вам не повезло, такого значения нет");
}
else
{
    System.Console.WriteLine($"Ваше число--->{myMatrix[row,col]}");
}

