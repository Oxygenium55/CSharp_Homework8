/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] InitArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindMinSumm(int[,] array)
{
    int minSumm = 0;
    int minLine = 0;
    int sumLine = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSumm += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumLine += array[i, j];
        }
        if (sumLine < minSumm)
        {
            minSumm = sumLine;
            minLine = i;
        }
        sumLine = 0;
    }
    Console.Write($"Строка с наименьшей суммой элементов: {minLine + 1} строка.");
}

int[,] matrix = InitArray(4, 4);
PrintArray(matrix);
Console.WriteLine();
FindMinSumm(matrix);
