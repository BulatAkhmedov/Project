

/*
Console.WriteLine("Введите X:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y:");
int y = int.Parse(Console.ReadLine());



int result = GetNubmerOfQuarter(x, y);

if (result == 0)
{
    Console.Write("X и Y равны нулю. Данные введены не правильно");
    return;
}

Console.Write("X и Y попадают в четверть ");
Console.Write(result);



int GetNubmerOfQuarter(int x, int y)
{

    if (x > 0 && y > 0)
{
    return 1;
}

if (x < 0 && y > 0)
{
    return 2;   
}

if (x < 0 && y < 0)
{
    return 3;    
}

if (x > 0 && y < 0)
{
    return 4;    
}    

return 0;
}
*/

/*
Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
/*
Console.WriteLine("Введите номер четверти:");
int quarter = int.Parse(Console.ReadLine());

string result = GetXY(quarter);

if (result == "0")
{
    Console.Write("Номер четверти введен не правильно");
    return;
}

Console.Write("В четверть попадаюат: ");
Console.Write(result);


string GetXY(int quarter)
{
    if (quarter == 1)
{
    return "X > 0 и Y > 0";
}

if (quarter == 2)
{
    return "X < 0 и Y > 0";   
}

if (quarter == 3)
{
    return "X < 0 и Y < 0";    
}

if (quarter == 4)
{
    return "X > 0 и Y < 0";    
}    

return "0";
}
*/

/*
Задача No21. Работа в группах
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21
*/
/*
Console.WriteLine("Введите X1:");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1:");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите X2:");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2:");
int y2 = int.Parse(Console.ReadLine());

double result = GetDistance(x1, x2, y1, y2);

if (result == 0)
{
    Console.Write("Переменные введены не правильно");
    return;
}

Console.Write("Расстояние между точками: ");
Console.Write(result);


double GetDistance(int x1, int x2, int y1, int y2)
{

    if (x1 == 0 & y1 == 0 & x2 == 0 & y2 == 0)
    {
        return 0;
    }

    double L = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(t2 - t1, 2));

    return L;

}
*/

 /*
 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4
*/

Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());

if (n == 0)
{
    Console.Write("n должно быть больше 0");
    return;
}

int[] array = new int[n];
int i = 1;

while (i <= n)
{
    array[i-1] = GetSquare(i);
    Console.WriteLine($"{i}, {array[i-1]}");
    i++;
}

int GetSquare(int j)
{
    j = j * j;
    return j;
}
