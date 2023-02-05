// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// System.Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     System.Console.WriteLine("Номер четверти 1");
// }
// else if (x < 0 && y > 0)
// {
//     System.Console.WriteLine("Номер четверти 2");
// }
// else if (x < 0 && y < 0)
// {
//     System.Console.WriteLine("Номер четверти 3");
// }
// else if (x > 0 && y < 0)
// {
//     System.Console.WriteLine("Номер четверти 4");
// }
// else
// {
//     System.Console.WriteLine("Точка лежит в начале координат");
// }
// -----------------------------------------------------------------------
// int InpunNumber(string str)
// {
//     System.Console.WriteLine(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FindQuarter(int a, int b)
// {
//     if (a > 0 && b > 0)
//     {
//         System.Console.WriteLine("Номер четверти 1");
//     }
//     else if (a < 0 && b > 0)
//     {
//         System.Console.WriteLine("Номер четверти 2");
//     }
//     else if (a < 0 && b < 0)
//     {
//         System.Console.WriteLine("Номер четверти 3");
//     }
//     else if (a > 0 && b < 0)
//     {
//         System.Console.WriteLine("Номер четверти 4");
//     }
//     else
//     {
//         System.Console.WriteLine("Точка лежит в начале координат");
//     }
// }

// int x = InpunNumber("Введите координату X");
// int y = InpunNumber("Введите координату Y");

// FindQuarter(x, y);

// ---------------------------------------------------------------
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Math.Pow() квадрат
// Math.Sqrt() корень

// int InpunNumber(string str)
// {
//     System.Console.WriteLine(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int x1 = InpunNumber("Введите координату X1");
// int y1 = InpunNumber("Введите координату Y1");
// int x2 = InpunNumber("Введите координату X2");
// int y2 = InpunNumber("Введите координату Y2");

// System.Console.WriteLine(Math.Round(Math.Pow(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2),0.5),3));

// -------------------------------------------------------------------
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// int InpunNumber(string str)
// {
//     System.Console.WriteLine(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int N = InpunNumber("Введите число N");

// for (int i = 1; i <= N; i++){
//      System.Console.Write(Math.Pow(i,2)+", ");
// }