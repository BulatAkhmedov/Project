﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Обязательно циклом без Math.Pow

*/

Console.WriteLine("Введите A:"); // Вывод в консоль предложения ввести число
int a = int.Parse(Console.ReadLine()); // введение в консоль числа

Console.WriteLine("Введите B:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(ExponentiationAtoB(a, b)); // выводд в консоль результат выполнения метода

//Метод типа int который возвращает число а возведенное в степень b
int ExponentiationAtoB(int a, int b)
{
    int tmp = a; // создание переменной типа int и приравнивание ее к переданному параметру а
    
    for(int i = 1; i < b; i++) // цикл от i до b
    {
        a = a * tmp; // возведение а в степень
    }

    return a; // возврат а как результат метода

}
