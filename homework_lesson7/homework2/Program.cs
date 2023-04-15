﻿/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
*/

Console.WriteLine("Введите размер двумерного массива");

Console.WriteLine("Введите количество строк");
bool isParsevasizerow = int.TryParse(Console.ReadLine(), out int sizeRow);

Console.WriteLine("Введите количество столбцов");
bool isParsesizecolumn = int.TryParse(Console.ReadLine(), out int sizeColumn);

if (!isParsevasizerow || !isParsesizecolumn) { Console.WriteLine("Ошибка ввода размености, введено не число"); return; }

Console.WriteLine("Введите индекс строки искомого элемента");
bool isParseindexrow = int.TryParse(Console.ReadLine(), out int indexRow);

Console.WriteLine("Введите индекс столбца искомого элемента");
bool isParseindexcolumn = int.TryParse(Console.ReadLine(), out int indexColumn);

int[,] array = Generate2DArray(sizeRow, sizeColumn);
Print2DArray(array);

Console.WriteLine($"Значение искомого элемента равно: {FindElemetToArray(array, indexRow, indexColumn)}");


// Метод создание двумерного массива типа int и заполнения его случайными числами 
int[,] Generate2DArray(int sizeRow, int sizeColumn)
{
    int[,] array = new int[sizeRow, sizeColumn];

    Random random = new Random();

    for (int i = 0; i < sizeRow; i++)
    {
        for (int j = 0; j < sizeColumn; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}


// Метод вывода двумерного массива в консоль
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}


// Метод поиска элемента в массиве по индексам
string FindElemetToArray(int[,] array, int i, int j)
{
    string result = string.Empty;

    if (i >= array.GetLength(0) && j >= array.GetLength(1))
    {
        result = "Искомого элемента не существует";
        return result;
    }

    result = $"{array[i,j]}";
    return result;

}