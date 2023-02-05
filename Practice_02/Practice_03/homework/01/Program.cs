// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");

string str = Console.ReadLine();

if (str.Length > 0 && str.Length < 6)
{
    char[] chars = str.ToCharArray(0, str.Length);
    string result = " ";
    int left = 0;
    int right = chars.Length - 1;
    while (left < right)
    {
        if (chars[left] != chars[right])
        {
            result = "нет";
        }
        else
        {
            result = "да";
        }
        left++;
        right--;
    }
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Число не пятизначное");
}

