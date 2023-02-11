// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int GetSumm(string s)
{
    int summ = 0;
    for (int i = 0; i < s!.Length; i++)
    {
        summ = summ + Convert.ToInt32(Convert.ToString(s[i]));
    }
return summ;
}

System.Console.WriteLine("Введите число");
string? str = Console.ReadLine();
System.Console.WriteLine(GetSumm(str));

