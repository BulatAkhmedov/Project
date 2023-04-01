/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());

if (n == 0)
{
    Console.Write("n должно быть больше 0");
    return;
}

int[] array = new int[n];
int i = 1;

while (i <= n)
{
    array[i-1] = GetSquare(i);
    Console.WriteLine($"{i}, {array[i-1]}");
    i++;
}

int GetSquare(int j)
{
    j = j * j * j;
    return j;
}