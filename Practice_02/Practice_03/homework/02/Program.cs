// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InpunNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InpunNumber("Введите координату X1");
int y1 = InpunNumber("Введите координату Y1");
int z1 = InpunNumber("Введите координату Z1");
int x2 = InpunNumber("Введите координату X2");
int y2 = InpunNumber("Введите координату Y2");
int z2 = InpunNumber("Введите координату Z2");

System.Console.WriteLine(Math.Round(Math.Pow(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2)+ Math.Pow(z2 - z1,2),0.5),3));