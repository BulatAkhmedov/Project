﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число N"); // Вывод в консоль предложения ввести число
int N = int.Parse(Console.ReadLine()); // Ввод в консоль числа 

int i = 1; // создание переменной типа int и приравнивание ее к 1

while (i <= N) // цикл от i до N
{
    if (i % 2 == 0) // если отстаток от деления i на 2 равен 0
    {
        Console.WriteLine(i); // если да вывод в консоль
    }
    
    i++; // прибавляем к i единицу
}
