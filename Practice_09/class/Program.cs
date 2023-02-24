// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// System.Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// Print(n);

// void Print(int num)
// {
//     if (num < 1)
//     {
//         return;
//     }
//     Print(num - 1);
//     System.Console.Write(num + "," );
// -----------------------------------------------------------------------------

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// System.Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());
// Print(n, m);

// void Print(int numM, int numN)
// {
//     if (numN < numM)
//     {
//         return;
//     }
//     Print(numM,numN - 1 );
//     System.Console.Write(numN + ",");
// }
// ---------------------------------------------------------------------------------
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// System.Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Summ(n,0));

// int Summ(int num, int sum)
// {
//     sum += num % 10;
//     if(num/10 == 0){
//         return sum;
//     }
//     return Summ(num / 10,sum);
// }
// ------------------------------------------------------------------------------------------------

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// System.Console.WriteLine("Введите числоA");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите числоB");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(GetResult(a, b, 1));

// int GetResult(int numA, int numB, int res)
// {
//     numB--;
//     if (numB >= 0)
//     {
//         res = res * numA;
//         return GetResult(numA, numB, res);
//     }
//     else
//     {
//         return res;
//     }
// }

