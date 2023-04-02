/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Обязательно циклом без Math.Pow

*/

Console.WriteLine("Введите A:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите B:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(ExponentiationAtoB(a, b));

int ExponentiationAtoB(int a, int b)
{
    int tmp = a;
    
    for(int i = 1; i < b; i++)
    {
        a = a * tmp;
    }

    return a;

}
