// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] CreatinRandomArray(int minValue = 1,int maxValue = 9)
{
    Console.WriteLine("Введите кол-во строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (rows > 0 && columns > 0)
    {
        int[,] arr = new int[rows,columns];
        var rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            arr[i, j] = rnd.Next(minValue,maxValue + 1);
            }
        }
        return arr;
    }
    else
    {
        System.Console.WriteLine("Введите длину масива (Целое и положительное число)");
        int[,] arr = new int [0,0];
        return arr;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumElementTheSmallest(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0,i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка"); 
}


int[,] arr = CreatinRandomArray();
PrintArray(arr);
SumElementTheSmallest(arr);