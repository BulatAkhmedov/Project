﻿/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Обязательно работать с int как на занятии 4
*/

Console.WriteLine("Введите число:"); // Вывод в консоль предложения ввести число
int number = int.Parse(Console.ReadLine()); // ввод в консоль числа

Console.WriteLine(GetSummNumber(number)); // вывод в консоль результата выполнения метода


// Метод определения суммы элементов массива
int GetSummNumber(int number)
{
    int [] array = BuildArrayFromNumers(number); // создание массива типа int и запись в него результата выполнения метода
    int summ = 0; // создание переменной типа int и приравнивание ее к 0
    
    for (int i = 0; i < array.Length; i++) // цикл от i до array.Length (длина массива)
    {
        summ += array[i];  // сложение переменной summ и элемента массива
    }

    return summ; // возврат переменной как результат метода

}


// Метод создания массива
int[] BuildArrayFromNumers(int number)
{
    int length = GetSizeNubmer(number); // создание переменной типа int с приравниванием к результату выполнения метода (получаем размер массива)

    int[] array = new int[length]; // создание массива типа int с указанием размера полученного ранее

    for (int i = 0; i < length; i++) // цикл от i до размера массива
    {
        array[i] = number % 10; // записываем в элемент массива остаток от деления переданого цисла на 10
        number = number / 10; // делим переданное число на 10 (уменьшаем его размер)
    }

    return array; // возвращаем получившийся массив как результат выполнения метода
}


// Метод получения длины массива
int GetSizeNubmer(int number)
{
    int i = 0; // создаем пременную типа int и приравниваем ее к 0

    while (number != 0) // цикл пока number не равен 0
    {
        number /= 10; // уменьшаем number путем деления на 10
        i++; // добавляем к i единицу (определяем размер массива)
    }

    return i; // возврат переменной как результат выполнения метода
}