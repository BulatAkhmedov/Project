﻿/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

// Задаем размерность массива
Console.WriteLine("Введите размерность массива:"); // вывод в консоль предложения ввести число
int length = int.Parse(Console.ReadLine()); // ввод в консоль числа

// Заполняем массив 
double[] array = GenerateArray(length); // создание массива типа int и запись в него результата выполнения метода

PrintArray(array);// вызов метода вывода массива в консоль
Console.WriteLine($"Максимальный элемент массива равен {FindMaxNumberArray(array)}"); // вывод в консоль рузельтата метода
Console.WriteLine($"Минимальный элемент массива равен {FindMinNumberArray(array)}"); // вывод в консоль рузультата метода
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {FindMaxNumberArray(array) - FindMinNumberArray(array)}"); // вывод в консоль разницы между результатами вывозов методов

// Вызываем метод создания массива и его заполнение случайными числами
double[] GenerateArray(int length)
{
    double[] array = new double[length]; // создание массива типа int и размером равным переданному параметру

    Random random = new Random(); // создание переменной типа Random

    for (int i = 0; i< length; i++) // цикл от i до length (размер массива)
    {
        array[i] = random.Next(0, 100) / 10.0; // запись в массив случайного числа
    }

    return array; // возврат массива как результат выполнения метода
}

//Метод определения минимального значения в массиве
double FindMinNumberArray (double[] array)
{
    double min = 100; // создаем переменную типа double и приравниваем ее к 0

    for(int i = 0; i < array.Length; i++) // цикл от i до array.Length (размер массива)
    {
        if (min > array[i]) // если min больше чем элемент массива
        {
            min = array[i]; // если да то приравниваем min к элементу массива
        }
    }
    
    return min; // возвращаем переменную как результат выполнения метода
}

//Метод определения максимального значения в массиве
double FindMaxNumberArray (double[] array)
{
    double max = 0; // создаем переменную типа double и приравниваем ее к 0

    for(int i = 0; i < array.Length; i++) // цикл от i до array.Length (размер массива)
    {
        if (max < array[i]) // если max меньше чем элемент массива
        {
            max = array[i]; // если да то приравниваем max к элементу массива
        }
    }
    
    return max; // возвращаем переменную как результат выполнения метода
}

// метод вывода массива в консоль
void PrintArray(double[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}