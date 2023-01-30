// Random rand = new Random();
// int number = rand.Next(100, 1000);
// System.Console.WriteLine(number);
// (number / 100)*10 + number % 10;
// result = result + Convert.ToString(number % 10);
// System.Console.WriteLine(result);

// System.Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a % b != 0)
// {
//     System.Console.WriteLine($"{a} не кратно {b} остаток {a % b}");
// }
// else
// {
//     System.Console.WriteLine($"{a} кратно {b}");
// }

Random rand = new Random();
int number = rand.Next(10, 1000);
System.Console.WriteLine(number);
System.Console.WriteLine((number / 10) % 10);