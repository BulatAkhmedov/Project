/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Random random = new Random();
int num = random.Next(100, 1000);

int first = num / 100;
int last = num % 10;

Console.WriteLine(num);
Console.WriteLine((first*10) + last);