// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


void Sort(int[,] mtx)
{
    int [,] result = new int [mtx.GetLength(0),mtx.GetLength(1)];
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        int[] tempArray = new int[mtx.GetLength(1)];
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            tempArray[j] = mtx[i, j];
        }
        BubbleSort(tempArray);
        Array.Reverse(tempArray);
        PrintArray(tempArray);
    }
}

static int[] BubbleSort(int[] array)
{
    var len = array.Length;
    for (var i = 1; i < len; i++)
    {
        for (var j = 0; j < len - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }

    return array;
}

int rows = ReadInt("Введите количество строк матрицы:");
int cols = ReadInt("Введите количество столбцов матрицы:");

var myMatrix = GenerateMAtrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine("----------------------");
Sort(myMatrix);
