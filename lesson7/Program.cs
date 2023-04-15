/*
Console.WriteLine("Введите размер двумерного массива");

Console.WriteLine("Введите первый параметр");
bool isParsevalue1 = int.TryParse(Console.ReadLine(), out int value1);

Console.WriteLine("Введите второй параметр");
bool isParsevalue2 = int.TryParse(Console.ReadLine(), out int value2);

int[,] array = Generate2DArray(value1,value2);
Print2DArray(array);

// метод создание двумерного массива типа int и заполнения его случайными числами 
int[,] Generate2DArray(int value1, int value2)
{
    int[,] array = new int[value1,value2];

    Random random = new Random();

    for (int i = 0; i < value1; i++)
    {
        for (int j = 0; j < value2; j++)
        {
            array[i,j] = random.Next(0, 10);
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
            Console.Write(array[i,j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}
*/

/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4. 0 1 23
1 2 34
2 3 45
*/
/*
Console.WriteLine("Введите размер двумерного массива");

Console.WriteLine("Введите первый параметр");
bool isParsevalue1 = int.TryParse(Console.ReadLine(), out int value1);

Console.WriteLine("Введите второй параметр");
bool isParsevalue2 = int.TryParse(Console.ReadLine(), out int value2);

if (!isParsevalue1 || !isParsevalue2) { return; }


int[,] array = Generate2DArray(value1,value2);
Print2DArray(array);


// Метод создание двумерного массива типа int и заполнения его случайными числами 
int[,] Generate2DArray(int value1, int value2)
{
    int[,] array = new int[value1,value2];

    for (int i = 0; i < value1; i++)
    {
        for (int j = 0; j < value2; j++)
        {
            array[i,j] = i + j;
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
            Console.Write(array[i,j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}
*/

/*
Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса нечетные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
1 47 2 5 92 3 8 42 4
Новый массив будет выглядеть вот так:
1 47 2
58129
8 42 4
25 мин
*/
/*
Console.WriteLine("Введите размер двумерного массива");

Console.WriteLine("Введите первый параметр");
bool isParsevalue1 = int.TryParse(Console.ReadLine(), out int value1);

Console.WriteLine("Введите второй параметр");
bool isParsevalue2 = int.TryParse(Console.ReadLine(), out int value2);

if (!isParsevalue1 || !isParsevalue2) { return; }


int[,] array = Generate2DArray(value1,value2);
Print2DArray(array);
Console.WriteLine();

FindElemet(array);
Print2DArray(array);


// Метод создание двумерного массива типа int и заполнения его случайными числами 
int[,] Generate2DArray(int value1, int value2)
{
    int[,] array = new int[value1,value2];

    Random random = new Random();

    for (int i = 0; i < value1; i++)
    {
        for (int j = 0; j < value2; j++)
        {
            array[i,j] = random.Next(0, 10);
        }
    }

    return array;

}

// Метод поиска нечетных индексов и возведение в квадрат их элементов
void FindElemet(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i += 2)
    {
        for (int j = 1; j < array.GetLength(1); j += 2)
        {
            array[i,j] = (int)Math.Pow(array[i,j], 2);
        }
    }
}


// Метод вывода двумерного массива в консоль
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

*/

/*
Задача 51: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, задан массив: 1 47 2
5 92 3
8 42 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.WriteLine("Введите размер двумерного массива");

Console.WriteLine("Введите первый параметр");
bool isParsevalue1 = int.TryParse(Console.ReadLine(), out int value1);

Console.WriteLine("Введите второй параметр");
bool isParsevalue2 = int.TryParse(Console.ReadLine(), out int value2);

if (!isParsevalue1 || !isParsevalue2) { return; }


int[,] array = Generate2DArray(value1,value2);
Print2DArray(array);
Console.WriteLine();

FindElemet(array);
Print2DArray(array);

Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали: {FindDiagonal(array)}");


// Метод создание двумерного массива типа int и заполнения его случайными числами 
int[,] Generate2DArray(int value1, int value2)
{
    int[,] array = new int[value1,value2];

    Random random = new Random();

    for (int i = 0; i < value1; i++)
    {
        for (int j = 0; j < value2; j++)
        {
            array[i,j] = random.Next(0, 10);
        }
    }

    return array;

}

// Метод поиска четных индексов и возведение в квадрат их элементов
void FindElemet(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i,j] = (int)Math.Pow(array[i,j], 2);
        }
    }
}

// Метод поиска суммы элементов в главной диагонали
int FindDiagonal(int[,] array)
{
    int result = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i < array.GetLength(1))
        {
            result += array[i,i];
        }  
    }
    
    return result;

}

// Метод вывода двумерного массива в консоль
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}
