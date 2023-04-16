/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/
/*
Console.WriteLine("Введите количество строк");
bool isParsedRow = int.TryParse(Console.ReadLine(), out int row);
Console.WriteLine("Введите количество столбцов");
bool isParsedCollum = int.TryParse(Console.ReadLine(), out int collum);

if (!isParsedRow || !isParsedCollum)
{
    Console.WriteLine("Введено не число");
    return;
}

int[,] array = Generate2DArray(row, collum);
Print2DArray(array);
Console.WriteLine();
SwappingPlaceRowToArray(array);
Print2DArray(array);

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

//Метод который поменяет местами первую и последнюю строку массива 

void SwappingPlaceRowToArray(int[,] array)
{
    int tmp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tmp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = tmp;
    }
}
*/

/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/
/*
Console.WriteLine("Введите количество строк");
bool isParsedRow = int.TryParse(Console.ReadLine(), out int row);
Console.WriteLine("Введите количество столбцов");
bool isParsedCollum = int.TryParse(Console.ReadLine(), out int collum);

if (!isParsedRow || !isParsedCollum)
{
    Console.WriteLine("Введено не число");
    return;
}

int[,] array = Generate2DArray(row, collum);
Print2DArray(array);
Console.WriteLine();
SwappingPlaceRowWithCollumToArray(array);
Print2DArray(array);

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

void SwappingPlaceRowWithCollumToArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("замена невозможна");
        return;
    }
    int[,] tmp = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmp[i, j] = array[i, j];
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[j, i] = tmp[i, j];
        }


    }
}
*/

/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза 1 встречается 1 раз 2 встречается 1 раз 8 встречается 1 раз 9 встречается 3 раза
1, 2, 3 4, 6, 1 2, 1, 6
1 встречается 3 раза 2 встречается 2 раз 3 встречается 1 раз 4 встречается 1 раз 6 встречается 2 раза
*/
/*
Console.WriteLine("Введите количество строк");
bool isParsedRow = int.TryParse(Console.ReadLine(), out int row);
Console.WriteLine("Введите количество столбцов");
bool isParsedCollum = int.TryParse(Console.ReadLine(), out int collum);

if (!isParsedRow || !isParsedCollum)
{
    Console.WriteLine("Введено не число");
    return;
}

int[,] array = Generate2DArray(row, collum);
Console.WriteLine();
Print2DArray(array);
Console.WriteLine();

var resultDictonary = new Dictionary<int, int>();
GenerateDictonry (array);

PrintDictonary(resultDictonary.Count);


//Метод создания двумерного массива и заполнение его случайными числами
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

//Метод вывода двумерного массива в консоль
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

// Метод заполнения словаря с перебором элементов массива
void GenerateDictonry (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (!resultDictonary.TryAdd(array[i,j], 1))
            {
                resultDictonary[array[i,j]] += 1;
            }
        }
    }
} 

//Метод вывода в консоль словаря
void PrintDictonary (int size)
{
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine(resultDictonary.ElementAt(i));
    }
}
*/

/*
Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.
*/

Console.WriteLine("Введите количество строк треугольника Паскаля:");
bool isParsedRow = int.TryParse(Console.ReadLine(), out int rowSize);

if (!isParsedRow) { Console.WriteLine("Ощибка ввода данных, введено не число"); return; }


int [,] array =  GeneratePascalArray(rowSize);
Console.WriteLine();

PrintPascalArray(array);


///Метод заполнения массива алгоритмом Паскаля:
int [,] GeneratePascalArray (int rowSize)
{

    int columnSize = rowSize + 2;
    int [,] array = new int [rowSize, columnSize];
    array[0, 0] = 0;
    array[0, 1] = 1;
    array[0, 2] = 0;

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }

    return array;
}


///Метод печати массива Паскаля:
void PrintPascalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int k = array.GetLength(0); k > i; k--)
            {
                Console.Write("  ");
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("{0,4}", array[i, j]);
                }
            }
        Console.WriteLine();
    }
}

