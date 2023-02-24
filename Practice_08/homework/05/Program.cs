// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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
//Честно признаюсь алгоритм подсмотрел
void FillMtx(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int s = 1;
    for (int y = 0; y < n; y++)
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < m; x++)
    {
        array[x, n - 1] = s;
        s++;
    }
    for (int y = n - 2; y >= 0; y--)
    {
        array[m - 1, y] = s;
        s++;
    }
    for (int x = m - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }

    int c = 1;
    int d = 1;

     while (s < m * n) {
            
            //Движемся вправо.
            while (array[c,d + 1] == 0) {
                array[c,d] = s;
                s++;
                d++;
            }

            //Движемся вниз.
            while (array[c + 1,d] == 0) {
                array[c,d] = s;
                s++;
                c++;
            }

            //Движемся влево.
            while (array[c,d - 1] == 0) {
                array[c,d] = s;
                s++;
                d--;
            }

            //Движемся вверх.
            while (array[c - 1,d] == 0) {
                array[c,d] = s;
                s++;
                c--;
            }
        }

        //При данном решении в центре всегда остаётся незаполненная ячейка.
        //Убираем её при помощи следующего цикла.
        for (int x = 0; x < m; x++) {
            for (int y = 0; y < n; y++) {
                if (array[x,y] == 0) {
                    array[x,y] = s;
                }
            }
        }

}

    int[,] matrix = new int[8, 4];
    FillMtx(matrix);
    PrintMatrix(matrix);

