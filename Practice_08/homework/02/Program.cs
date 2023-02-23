// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



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
            matrix[i, j] = rand.Next(1, 11);
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

void PrintArray(int[] arr)
{
    System.Console.WriteLine(string.Join("\t", arr));
}


int[] FindSumms(int[,] mtx)
{
    int[] result = new int[mtx.GetLength(0)];

    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            summ = summ + mtx[i, j];
        }
        result[i] = summ;
    }
    return result;
}

int FindMin(int[] arr)
{
    int min = arr[1];
    int minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            minIndex = i+1;
        }
    }
    return minIndex;
}

int rows = ReadInt("Введите количество строк матрицы:");
int cols = ReadInt("Введите количество столбцов матрицы:");

var myMatrix = GenerateMAtrix(rows, cols);
PrintMatrix(myMatrix);

var summs = FindSumms(myMatrix);
PrintArray(summs);
System.Console.WriteLine($"{FindMin(summs)} строка");