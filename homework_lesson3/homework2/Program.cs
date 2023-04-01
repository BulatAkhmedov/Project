/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите X1:");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1:");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z1:");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите X2:");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2:");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z2:");
int z2 = int.Parse(Console.ReadLine());

double result = GetDistance(x1, x2, y1, y2, z1, z2);

if (result == 0)
{
    Console.Write("Переменные введены не правильно");
    return;
}

Console.Write("Расстояние между точками: ");
Console.Write(result);


double GetDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{

    if (x1 == 0 & x2 == 0 & y1 == 0 & y2 == 0 & z1 == 0 & z2 == 0)
    {
        return 0;
    }

    double L = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    return L;

}