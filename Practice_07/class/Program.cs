// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }



// int[,] GenerateMAtrix(int rows, int cols)
// {

//     Random rand = new Random();
//     int [,] matrix = new int [rows,cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             matrix[i,j] = rand.Next(0,11);
//         }
//     }
// return matrix;
// }

// void PrintMatrix(int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            System.Console.Write(matrix[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = ReadInt("Введите количество строк матрицы:");
// int cols = ReadInt("Введите количество столбцов матрицы:");

// var myMatrix = GenerateMAtrix(rows,cols);
// PrintMatrix(myMatrix);