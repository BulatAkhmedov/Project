// ЗАДАЧА 1
/*
Задача No1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет

Console.WriteLine("Программа определения является ли число а квадратом числа b");

Console.WriteLine("Введите b");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите a");
int a = int.Parse(Console.ReadLine());


if (a == (b * b))
{
    Console.WriteLine("Число b является квадратом числа a");
}
else
{
    Console.WriteLine("Число b не является квадратом числа a");
}
*/

// ЗАДАЧА 3
/*
Задача No3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
20 минут

Console.WriteLine("Введите значене от 1 до 7");
int a= int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("Понедельник");
}

if (a == 2)
{
    Console.WriteLine("Вторник");
}

if (a == 3)
{
    Console.WriteLine("Среда");
}

if (a == 4)
{
    Console.WriteLine("Четверг");
}

if (a == 5)
{
    Console.WriteLine("Пятница");
}

if (a == 6)
{
    Console.WriteLine("Суббота");
}

if (a == 7)
{
    Console.WriteLine("Воскресенье");
}

if (a > 1 | a > 7)
{
    Console.WriteLine("Нет такого дня");
}
*/

//Задача No5. 
/*
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/
/*
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

int i = -N;

while (i <= N)
{
    Console.WriteLine(i);
    i = i + 1;

}
*/

//Задача No7.
/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 ->6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите трехзначное число");
int a= int.Parse(Console.ReadLine());

if (a > 99 & a < 1000)
{
    Console.WriteLine(a % 10);
}
else 
{
    Console.WriteLine("Введите трехзначное число");
}





