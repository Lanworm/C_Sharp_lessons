// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] GetArray(int size)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int GetDifference(int[] arr)
{

    int max = 0;
    int min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return max - min;
}

int[] myArray = GetArray(4);
PrintArray(myArray);
System.Console.WriteLine(GetDifference(myArray));