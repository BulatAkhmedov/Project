/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначную переменную:");
string str = Console.ReadLine();

// Данное условие введено только из-за условий задачи. Метод расчитан на переменную любой длины
if (str.Length != 5)
{
    Console.WriteLine("Введена не пятизначная переменная");
    return;
}


if (DefenitionPolynomial(str))
{
    Console.WriteLine("Переменная является палиндромом");
}
else
{
    Console.WriteLine("Переменная не является палиндромом");
}

bool DefenitionPolynomial(string str)
{
    bool status = false;

    for (int i = 0; i < (str.Length/2); i++)
    {
        if (str[i] == str[str.Length - (i+1)])
        {
            status = true;
        }
        else
        {
            status = false;
            return false;
        }
    }
    
    return status;

}