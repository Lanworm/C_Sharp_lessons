// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите числа через запятую");
string? strInput = Console.ReadLine();
int max = 0;
if (strInput != null)
{
    string[] numbers = strInput.Split(","); // как обработать null в одну строку?
    foreach (string number in numbers)
    {
        int intNum = Convert.ToInt32(number);
        if (intNum > max)
        {
            max = intNum;
        }
    }

    System.Console.WriteLine($"{strInput} -> max {max}");
}
