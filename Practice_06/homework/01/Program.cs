// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int GetSumPositive(int[] arr)
{
    int result=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0){
            result++;
        }
    }
    return result;
}

System.Console.WriteLine("Введите числа через запятую: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
System.Console.WriteLine(GetSumPositive(array));
