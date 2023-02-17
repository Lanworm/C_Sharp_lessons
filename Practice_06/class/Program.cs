// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// metka:
// System.Console.WriteLine("Введите числа: ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// if (array.Length != 3)
// {
//     System.Console.WriteLine("Массив введён некоректно ");
//     goto metka;
// }

// if ((array[0] + array[1]) > array[2] && (array[1] + array[2]) > array[0] && (array[0] + array[2] > array[1]))
// {
//     System.Console.WriteLine("Такой треугольник существует ");
// }
// else
// {
//     System.Console.WriteLine("Такой треугольник не существует ");
// }
// ------------------------------------------------------------------------------------
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3  -> 11
// 2  -> 10


// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string st = "";

// while (n != 0)
// {
//     st += n % 2;
//     n = n / 2;
// }

// for (int i = st.Length - 1; i >= 0; i--)
// {
//     System.Console.Write(st[i]);
// }
// System.Console.WriteLine();

void GetBinary(int number)
{
    if (number <= 0) return;
    GetBinary(number / 2);
    System.Console.Write(number % 2);
}

GetBinary(44);