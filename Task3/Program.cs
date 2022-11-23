/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int UserNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

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
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------");
}

int m = UserNumber("Задайте количество строк: ");
int n = UserNumber("Задайте количество столбцов: ");
Console.WriteLine();

int[,] firstMatrix = InitArray(m, n);
PrintArray(firstMatrix);

int[,] secondMatrix = InitArray(m, n);
PrintArray(secondMatrix);

int[,] resultMatrix = new int[m, n];

if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine("Нельзя выполнить умножение заданных матриц.");
    return;
}
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
}

PrintArray(resultMatrix);

