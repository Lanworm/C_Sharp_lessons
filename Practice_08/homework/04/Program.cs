// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(int[] arr)
{
    System.Console.WriteLine(string.Join(" ", arr));
}
int[,,] Generate3DMatrix(int sizeX, int sizeY, int sizeZ)
{
    int[] checkUnic = new int[sizeX * sizeY * sizeZ];
    int count = 0;
    int[,,] result = new int[sizeX, sizeY, sizeZ];
    Random rand = new Random();
    for (int x = 0; x < sizeX; x++)
    {
        for (int y = 0; y < sizeY; y++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
            restart:
                int n = rand.Next(10, 100);
                if (!checkUnic.Contains(n))
                {
                    result[x, y, z] = n;
                    checkUnic[count] = n;
                    count++;
                    // PrintArray(checkUnic);
                }
                else
                {
                    // System.Console.WriteLine($"Не уникальное число! {n}");
                    goto restart;
                }

            }
        }
    }
    return result;
}

void Print3DMatrix(int[,,] mtx)
{
    for (int x = 0; x < mtx.GetLength(0); x++)
    {
        
        for (int y = 0; y < mtx.GetLength(1); y++)
        {
            string[] line = new string[3];
            for (int z = 0; z < mtx.GetLength(2); z++)
            {
                line[x] = line[x] + " " + $"({x},{y},{z}) {Convert.ToString(mtx[x,y,z])}\t" ;
            }
            System.Console.WriteLine(string.Join("", line));
           
        }
        System.Console.WriteLine();
    }
}

var myMatrix3D = Generate3DMatrix(3, 3, 3);
Print3DMatrix(myMatrix3D);