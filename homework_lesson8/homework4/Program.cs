/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.WriteLine("Введите X:");
bool isParseX = int.TryParse(Console.ReadLine(), out int x);

Console.WriteLine("Введите Y:");
bool isParseY = int.TryParse(Console.ReadLine(), out int y);

Console.WriteLine("Введите Z:");
bool isParseZ = int.TryParse(Console.ReadLine(), out int z);

if (!isParseX || !isParseY || !isParseZ) { Console.WriteLine("Ошибка ввода размености, введено не число"); return; }

int[,,] array3D = Generate3DArray(x, y, z);
Print3DArray(array3D);

// Метод создание трехмерного массива типа int и заполнения его случайными не повторяющимися числами 
int[,,] Generate3DArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    var tmpDictonary = new Dictionary<int, int>();
    Random random = new Random();

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z;)
            {
                int tmp = random.Next(10, 100);

                if (!tmpDictonary.TryAdd(tmp, 1)) { continue; }

                array[i, j, k] = tmp;
                k++;
            } 
        }
    }
    return array;
}


// Метод вывода трехмерного массива в консоль
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"[{i}, {j}, {k}] - {array[i,j,k]}");
            }
        }
    }
}