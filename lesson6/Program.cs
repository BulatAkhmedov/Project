﻿
/*
int[] array = new int[]{ 1, 2, 3, 4 ,5}; // создание массива типа int и запись в него значений
PrintArray(array); // вызов метода вывода массива в консоль

int[] reversed = Revers(array); // создание массива типа int и запись в него результат выполнения метода
PrintArray(reversed); // вызов метода вывода массива в консоль

ReversVoid(array); // вызов метода переворота элементов в переданном массива
PrintArray(array); // вызов метода вывода массива в консоль

// Метод для переворота массива 1
// Метод создания массива и записи в него перевернутого переданного массива
int[] Revers(int[] array)
{
    int[] reversed = new int[array.Length]; //создание массива типа int с длинной равной длине переданного массива

    for(int i = 0; i < array.Length; i++) // цикл от i до array.Length (длина массива)
    {
        reversed[i] = array[array.Length -1 -i]; //запись в 0 элемент нового массива последнего элемента переданного массива
    }

    return reversed; // возврат результата получившегося в процессе выполения метода
}

//Метод для переворота массива 2
// Метод переворота элементов в переданном массиве
void ReversVoid(int[] array)
{
    int tmp = 0; // создание переменной типа int и приравнивание ее к 0
    for (int i = 0; i < array.Length / 2; i++) // цикл от i до array.Length / 2 (половина длины массива)
    {
        tmp = array[i]; // создаем переменную типа int и записываем в нее значение первого элемента массива
        array[i] = array[array.Length -i -1]; // в первый элемент массива записываем значение последнего элемента массива
        array[array.Length -i -1] = tmp; // в последний элемент массива записываем значение созданной переменной (значение первого элемента массива, тем самым меняем их местами)
    }
}

// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}
*/

/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
/*
Console.WriteLine("Введите сторону треугольника 1"); // Вывод в консоль предложения ввести число
int tmp1 = int.Parse(Console.ReadLine()); // Ввод в консоль числа

Console.WriteLine("Введите сторону треугольника 2");
int tmp2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону треугольника 3");
int tmp3 = int.Parse(Console.ReadLine());

Console.WriteLine(Find(tmp1, tmp2, tmp3)); // отображения в консоль результат выполнения метода

// Метод типа string проверяющий что каждая сторона треугольника меньше суммы двух оставшихся сторон
string Find(int tmp1, int tmp2, int tmp3)
{
    string str = string.Empty;// создаем переменную типа string и заполняем ее пустотой

    if (tmp1 < tmp2 + tmp3 && tmp2 < tmp1 + tmp3 && tmp3 < tmp1 + tmp2) // условие проверки что каждая стороная меньше суммы двух других сторон
    {
        str = "Треугольник существует"; // если да вывод в консоль
    }
    else
    {
        str = "Треугольник не существует"; // если нет вывод в консоль
    }

    return str; // возврат переменной как результат выполнения метода
}
*/


/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
/*
Console.WriteLine("Введите число"); // вывод в консоль предложения ввести число
bool isParsed = int.TryParse(Console.ReadLine(), out int number); // ввод числа в консоль с дополнительной проверкой введено ли число
                                                                  // приравниваем к переменной типа bool, используем метод TryParse в котором указан параметр out int number
                                                                  // если введены числа, а не буквы то на выходе получим переменную number типа int с записанным в нее числом,
                                                                  // если нет то в переменную запишется default значение равное 0

if (!isParsed) // проверка если было введено не число переменная типа bool isParsed имеет значение ложь
{
    Console.WriteLine("Введено не число"); // вывод в консоль
    return; // прекращение работы программы
}

Console.WriteLine(Translation(number)); // вывод в консоль результат выполнения метода

// Метод типа string который преобразовывает десетично число в двоичное
string Translation(int number)
{
    string str = string.Empty; // создаем переменную типа string и записываем в нее пустоту 

    while(number != 0) // условие пока number не равен 0
    {
        str = number%2 + str; // добавляем в начало строки остаток от деления number на 2 (обязательно в начало строки и поэтому number%2 является первым аргументом формулы)
        number /= 2; // уменьшаем переменную путем деления на 2
    }

    return str; // возврат переменной как результат выполнения метода
}
*/


/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
/*
Console.WriteLine("Введите число"); // вывод в консоль предложения ввести число
bool isParsed = int.TryParse(Console.ReadLine(), out int number); // ввод числа в консоль с проверкой что введены числа, а не буквы

if (!isParsed) // проверка введены ли числа, а не буквы
{
    Console.WriteLine("Введено не число"); // если введены буквы вывод в консоль
    return; // прекращение работы программы
}

int[] array = GenerateArray(number); // создание массива типа int и запись в него результат выполнения метода

PrintArray(array); // выполнение метода выводящего массив в консоль


// Метод создания массива типа int и заполнения его числами Фибоначчи
int[] GenerateArray(int number)
{
    int[] array = new int[number]; // создаем массив типа int с размерностью равной переданному параметру

    for(int i = 0; i < array.Length; i++) // цикл от i до array.Length (длина массива)
    {
        if (i == 0) // проверяем если первый элемент массива
        {
            array[i] = 0; // записываем в него 0
        }
        else if (i == 1) // проверяем если второй элемент массива
        {
            array[i] = 1; // записываем в него 1
        }
        else // во всех остальных случаях (если элемент массива не 0 и не 1)
        {
            array[i] = array[i-2] + array[i -1]; // записываем сумму двух предыдущих элементов
        }
    }

    return array; // возврат массива как результат выполнения метода
}

// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}
*/



/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

Console.WriteLine("Введите размер массива"); // вывод в консоль предложения ввести число
bool isParsed = int.TryParse(Console.ReadLine(), out int number); // ввод числа в консоль с проверкой что введены числа, а не буквы

if (!isParsed) // условие проверка что введены числа
{
    Console.WriteLine("Введено не число"); // если введены буквы вывод в консоль
    return; // прекращение работы программы
}

//При создании копии исходного массива мы в метода создаем новый массив (выделяем под него память использую метод new), а после поэлементно копируем в него значения исходного массива строка 219
//При создании массива и просто копировании в него исходного мы не создаем нового массива, а копируем в него ссылку на исходный строка 192. Получается что ихменяя tmparray мы будем изменять исходный array
//Метод сравнения двух массивов (строки 197 и 199) осуществляет не сравнение элементов данных массивов, а сравнивает их ссылки на участки памяти, а именно в первом случае строка 197 будет false так как под них выделены разные участки, а во втором случае будет true так как это один и тот же массив.

int[] array = GenerateArray(number); // создание массива типа int и запись в него результата выполнения метода
PrintArray(array); // вызов метода выводящего в консоль массив

int[] tmparray = array; // созданние массива типа int и запись в него ссылки на исходный массив

int[] copyarray = ArrayCopyTo(array); // создание массива типа int и запись в него рузельтата выполнения метода
PrintArray(copyarray); // вызов метода выводящего в консоль массив

Console.WriteLine(array == copyarray); // вывод в консоль результата сравнения ссылок на разные массивы (копии и исходного) будет false так как под них выделены отдельные участки памяти

Console.WriteLine(array == tmparray); // вывод в консоль результата сравнения ссылок массивов которые лежат по одной ссылке. будет true так как это ссылки на один и тот же участок памяти

// Метод создания массива типа int и его заполнение случайными числами
int[] GenerateArray(int number)
{
    int[] array = new int[number]; // создание массива типа int и размером равным переданному параметру

    Random random = new Random(); // создание переменной типа Random

    for (int i = 0; i< number; i++) // цикл от i до length (размер массива)
    {
        array[i] = random.Next(0, 10); // запись в массив случайного числа
    }

    return array; // возврат массива как результат выполнения метода
}

// Метод создания нового массива типа int и поэлементном копировании в него исходного (переданного массива)
int[] ArrayCopyTo(int[] array)
{
    int[] copyarray = new int[array.Length]; // создаем новый массив типа int с размером равным длине исходного (переданного массива)

    for (int i = 0; i < array.Length; i++) // цикл от i до array.Length (длина исходного (переданного) массива)
    {
        copyarray[i] = array[i]; // поэлементное копирование в новый массив значений исходного (переданного)
    }

    return copyarray; // возврат массива как результат выполения метода
}

// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}
