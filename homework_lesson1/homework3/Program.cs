﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число "); // Вывод в консоль предложения ввести число
int a = int.Parse(Console.ReadLine()); // Ввод в консоль числа

if (a % 2 == 0) // если остаток от деления а на 2 равен 0
{
    Console.WriteLine("Число четное"); // если да вывод в консоль
}
else
{
    Console.WriteLine("Число не четное"); // если нет вывод в консоль
}

