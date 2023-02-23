// // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMAtrix(int rows, int cols)
// {

//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = rand.Next(0, 11);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ChangeRowCol(int[,] mtx)
// {
//     int temp;
//     for (int i = 0; i < mtx.GetLength(1); i++)
//     {
//         temp = mtx[0, i];
//         mtx[0, i] = mtx[mtx.GetLength(0) - 1, i];
//         mtx[mtx.GetLength(0) - 1, i]=temp;
//     }
// }

// int rows = ReadInt("Введите количество строк матрицы:");
// int cols = ReadInt("Введите количество столбцов матрицы:");

// var myMatrix = GenerateMAtrix(rows, cols);
// PrintMatrix(myMatrix);
// ChangeRowCol(myMatrix);
// System.Console.WriteLine("----------------------");
// PrintMatrix(myMatrix);
//-------------------------------------------------------------------------------------------
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMAtrix(int rows, int cols)
// {

//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = rand.Next(0, 11);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] Rotate(int[,] mtx)
// {
//     int[,] result = new int[mtx.GetLength(1), mtx.GetLength(0)];
//     for (int i = 0; i < mtx.GetLength(0); i++)
//     {
//         for (int j = 0; j < mtx.GetLength(1); j++)
//         {
//             result[j, i] = mtx[i, j];
//         }
//     }
//     return result;
// }

// int rows = ReadInt("Введите количество строк матрицы:");
// int cols = ReadInt("Введите количество столбцов матрицы:");

// var myMatrix = GenerateMAtrix(rows, cols);
// PrintMatrix(myMatrix);
// System.Console.WriteLine("----------------------");
// PrintMatrix(Rotate(myMatrix));

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMAtrix(int rows, int cols)
// {

//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i, j] = rand.Next(0, 11);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             System.Console.WriteLine($"{i} встречается {arr[i]} раз");
//         }
//     }
// }


// int[] FreqDict(int[,] mtx)
// {
//     int[] result = new int[10];
//     for (int k = 0; k < 10; k++)
//     {
//         int count = 0;
//         for (int i = 0; i < mtx.GetLength(0); i++)
//         {
//             for (int j = 0; j < mtx.GetLength(1); j++)
//             {
//                 if (k == mtx[i, j])
//                 {
//                     count++;
//                 }
//             }
//         }
//         result[k] = count;
//     }
//     return result;
// }

// int rows = ReadInt("Введите количество строк матрицы:");
// int cols = ReadInt("Введите количество столбцов матрицы:");

// var myMatrix = GenerateMAtrix(rows, cols);
// PrintMatrix(myMatrix);
// System.Console.WriteLine("----------------------");
// PrintArray(FreqDict(myMatrix));