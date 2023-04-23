/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите N:");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN) { Console.WriteLine("Ошибка ввода, введено не число"); return; }

Print(n);

void Print(int n, int start = 1)
{
    if (start > n) { return; }

    Console.WriteLine(start);
    start++;
    
    Print(n, start);

}