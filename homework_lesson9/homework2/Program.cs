/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите начало диапазона:");
bool isParsedStart = int.TryParse(Console.ReadLine(), out int start);

Console.WriteLine("Введите конец диапазона:");
bool isParsedStop = int.TryParse(Console.ReadLine(), out int stop);

if (!isParsedStart || !isParsedStop) { Console.WriteLine("Ошибка ввода, введено не число"); return;}

Console.WriteLine(SummElement(start, stop));

int SummElement (int m, int n)
{
    
    if (n < m) { return 0; }

    n--;

    return SummElement(m, n) + n+1;
}
