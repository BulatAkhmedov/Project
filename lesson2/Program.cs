/*
Random random = new Random();
int randomValue = random.Next(10, 100);

int lastDigit = randomValue % 10;
int firstDigit = randomValue / 10;

Console.WriteLine(randomValue);
Console.WriteLine(lastDigit);
Console.WriteLine(firstDigit);

if (lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine(firstDigit);
}
*/

/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
● 456 -> 46
● 782 -> 72
● 918 -> 98
*/
/*
Random random = new Random();
int num = random.Next(100, 1000);

int first = num / 100;
int last = num % 10;

Console.WriteLine(num);
Console.WriteLine((first*10) + last);
*/

/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
● 34, 5 -> не кратно, остаток 4
● 16, 4 -> кратно
*/
/*
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num2 % num1 == 0)
{
    Console.WriteLine("Второе число является кратным первому.");
}
else
{
    Console.WriteLine("Второе число не кратно первому. Остаток от деления: " + (num2 % num1));
}

Console.ReadKey();
*/

/*
Задача No14. Общее обсуждение
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да
*/
/*
Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2)
{
    Console.WriteLine("Число 1 является квадратом числа 2");
}
else if (num2 * num2 == num1)
{
    Console.WriteLine("Число 2 является квадратом числа 1");
}
else
{
    Console.WriteLine("Числа не явдяются квадратами друг друга");
}
*/
/*
Задача No16. Работа в группах
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
● 5, 25 -> да ● -4, 16 -> да ● 25, 5 -> да ● 8,9 -> нет
*/
/*
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
    
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}
*/