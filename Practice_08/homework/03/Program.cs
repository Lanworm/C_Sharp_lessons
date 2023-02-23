// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
    System.Console.WriteLine("----------------------");
}

int[,] MtxMultiplication(int[,] mtxA, int[,] MtxB)
{

    int[,] result = new int[mtxA.GetLength(0), MtxB.GetLength(1)];
    for (int i = 0; i < mtxA.GetLength(0); i++)
    {
        for (int j = 0; j < MtxB.GetLength(1); j++)
        {
            for (int k = 0; k < MtxB.GetLength(0); k++)
            {
                result[i, j] += mtxA[i, k] * MtxB[k, j];
            }
        }
    }
    return result;
}

startPoint:

Console.WriteLine("Введите размерность первой матрицы через запятую: ");
int[] sizeA = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
var myMatrixA = GenerateMAtrix(sizeA[0], sizeA[1]);


Console.WriteLine("Введите размернсть второй матрицы через запятую: ");
int[] sizeB = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
var myMatrixB = GenerateMAtrix(sizeB[0], sizeB[1]);


if (myMatrixA.GetLength(1) != myMatrixB.GetLength(0))
{
    System.Console.WriteLine("Матрицы нельзя перемножить");
    goto startPoint;
}
PrintMatrix(myMatrixA);

PrintMatrix(myMatrixB);

var mult = MtxMultiplication(myMatrixA, myMatrixB);
PrintMatrix(mult);
