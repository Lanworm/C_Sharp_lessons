// string? num = Console.ReadLine();

// if(num!.Length == 5){

// }


// int convertedNum = Convert.ToInt32(Convert.ToString(num[2]));

// ------------------------------------------------------------------
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int GetNumber(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int GetSumElements(int a)
// {
//     int result = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         result += i;
//     }
//     return result;
// }

// int num = GetNumber("Введите число А: ");
// int res = GetSumElements(num);

// System.Console.WriteLine($"Сумма чисел от 1 до {num} = {res}");
// ----------------------------------------------------------------------
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// System.Console.WriteLine("Введите число");
// string? str = Console.ReadLine();
// System.Console.WriteLine(str!.Length);

// ----------------------------------------------------------------------
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120





// long GetNumber(string text)
// {
//     System.Console.WriteLine(text);

//     return Convert.ToInt32(Console.ReadLine());
// }

// long GetResult(long n)
// {
//     long result = 1;
//     for (long i = 1; i <= n; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }

// long N = GetNumber("Введите число");
// System.Console.WriteLine(GetResult(N));


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

var rand = new Random();

string GetRandomArr(int n)
{
    string nums ="";

    for (int i = 0; i < n; i++)
    {
        nums = nums + rand.Next(0, 2)+",";
    }
    return nums;
}

System.Console.WriteLine(GetRandomArr(8));