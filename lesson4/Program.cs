/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 5 -> 120
*/
/*
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());

int result = GetComposition(n);

Console.WriteLine(result);

int GetComposition(int number)
{
    int result = 1;
    
    for(int i = 1; i <= number; i++)
    {
        result *= i;
    }

    return result;
    
}
*/


/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Console.WriteLine("Введите N:");
int stop = int.Parse(Console.ReadLine());
int start = 1;

int[] arrayend = FillArray(start, stop);

PrintArray(arrayend);


// Метод вывода в консоль массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) // создание цикла
    {
        Console.Write($"{array[i]} "); // Вывод в консоль
    }
}

// Метод заполнения массива случайными числами (0, 1)
int[] FillArray(int start, int stop)
{
    int[] array = new int[stop];

    Random random = new Random();

    for (int i = start; i < stop; i++)
    {
        int randomValue = random.Next(0, 2);
        array[i] = randomValue;
    }

    return array;
}






