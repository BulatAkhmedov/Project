/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели:");
int number = int.Parse(Console.ReadLine());
    
switch(number)
{
    case 1:
    Console.WriteLine("Понедельник не выходной");
    break;

    case 2:
    Console.WriteLine("Вторник не выходной");
    break;

    case 3:
    Console.WriteLine("Среда не выходной");
    break;

    case 4:
    Console.WriteLine("Четверг не выходной");
    break;

    case 5:
    Console.WriteLine("Пятница не выходной");
    break;

    case 6:
    Console.WriteLine("Суббота выходной");
    break;

    case 7:
    Console.WriteLine("Воскресенье выходной");
    break;

    default:
    Console.WriteLine("День недели введен не правильно");
    break;
}