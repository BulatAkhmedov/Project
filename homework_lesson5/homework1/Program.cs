/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// Задаем размерность массива
Console.WriteLine("Введите размерность массива:");
int lenght = int.Parse(Console.ReadLine());

// Заполняем массив 
int[] array = GenerateArray(lenght);

// Вызываем метод создания массива и его заполнение случайными числами
int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];

    Random random = new Random();

    for (int i = 0; i< lenght; i++)
    {
        array[i] = random.Next(99, 1000);
    }

    return array;
}