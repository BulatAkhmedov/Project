﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели:"); // вывод в консоль предложения задать числом день недели
int number = int.Parse(Console.ReadLine()); // ввод в консоль числа
    
switch(number) // // условие выбора если number (введенный день недели)
{
    case 1: // равен 1
    Console.WriteLine("Понедельник не выходной"); // вывод в консоль
    break;

    case 2: // и т.д.
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

    default: // во всех остальных случаях
    Console.WriteLine("День недели введен не правильно"); // вывод в консоль
    break;
}