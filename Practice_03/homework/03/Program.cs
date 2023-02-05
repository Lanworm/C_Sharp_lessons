// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int InpunNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int N = InpunNumber("Введите число N");

for (int i = 1; i <= N; i++)
{
    System.Console.Write(Math.Pow(i, 3) + ", ");
}