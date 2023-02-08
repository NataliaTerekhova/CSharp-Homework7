/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.  */

int[,] arr = Generate2DArray(3, 4);
Print2DArray(arr);
System.Console.WriteLine();
GetAverage(arr);

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
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

void GetAverage(int[,] arr)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double av = 0;
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        av = sum / (arr.GetLength(1) - 1);
        System.Console.Write($"{av}; ");
    }

}


