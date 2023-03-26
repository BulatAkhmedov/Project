/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число:");
string str = Console.ReadLine();
int number = int.Parse(str);

switch(str.Length)
{
    case 1:
    Console.WriteLine("Третьей цифры нет");
    break;

    case 2:
    Console.WriteLine("Третьей цифры нет");
    break;

    case 3:
    Console.WriteLine(number % 10);
    break;

    default:
    int tmp;
    int tmppow = 10;
    int i = 0;

    while (i < str.Length-3)
    {
        tmppow = tmppow * tmppow;
        i++;
    }

    tmp = number % tmppow;
    Console.WriteLine(tmp % 10);
    break;
}

