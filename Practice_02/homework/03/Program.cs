// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (n > 7)
{
    System.Console.WriteLine("Нет такого дня недели");
}
else
{
    if (n == 6 || n == 7)
    {
        System.Console.WriteLine("да");
    }
    else
    {
        System.Console.WriteLine("нет");
    }
}