/* Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет   */

int[,] arr = Generate2DArray(10, 10);
Print2DArray(arr);
System.Console.WriteLine();
int i = new Random().Next(1, 15);
int j = new Random().Next(1, 15);
System.Console.WriteLine($"Позиции элемента: {i}, {j}");
System.Console.WriteLine();
CheckArrayElement(arr, i, j);
if (false)
{
    System.Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    System.Console.WriteLine(arr[i, j]);
}


int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($" {arr[i, j]}");
        }
        System.Console.WriteLine();
    }
}

bool CheckArrayElement(int[,] arr, int i, int j)
{
    if (i < arr.GetLength(0) && j < arr.GetLength(1))
    {
        return true;

    }
    else
    {
        return false;

    }
}

