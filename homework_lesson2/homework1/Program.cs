﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Random random = new Random(); // создание переменной типа Random
int num = random.Next(100, 1000); // создание переменной типа int и запись в нее случайного числа

int first = num / 100; // создание переменной типа int и запись в нее результата деления случайного числа на 100 (первый элемент трехзначного числа)
int last = num % 10; // создание переменной типа int и запись в нее остаток от деления случайного числа на 10 (последний элемент трехзначного числа)

Console.WriteLine(num); // вывод в консоль трехзначного числа
Console.WriteLine((first*10) + last); // вывод в консоль первого элемента умноженного на 10 и сложенного с последним элементом (получение двузначного числа из трехзначного)