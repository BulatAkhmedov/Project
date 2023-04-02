/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Обязательно работать с int как на занятии 4
*/

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(GetSummNumber(number));


// Метод определения суммы элементов массива
int GetSummNumber(int number)
{
    int [] array = BuildArrayFromNumers(number);
    int summ = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        summ += array[i]; 
    }

    return summ;

}


// Метод создания массива
int[] BuildArrayFromNumers(int number)
{
    int length = GetSizeNubmer(number);

    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = number % 10;
        number = number / 10;
    }

    return array;
}


// Метод получения длины массива
int GetSizeNubmer(int number)
{
    int i = 0;

    while (number != 0)
    {
        number /= 10;
        i++;
    }

    return i;
}