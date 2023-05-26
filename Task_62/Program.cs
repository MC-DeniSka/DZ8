// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateAndFillArraySpiral(int rows = 4, int columns = 4)
{
    int[,] arr = new int[rows, columns];
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < rows * columns; e++)
    {
        int k = 0;
        do { arr[i, j++] = value++; } while (++k < rows - 1);
        for (k = 0; k < rows - 1; k++) arr[i++, j] = value++;
        for (k = 0; k < rows - 1; k++) arr[i, j--] = value++;
        for (k = 0; k < rows - 1; k++) arr[i--, j] = value++;
        ++i; ++j;
        rows = rows < 2 ? 0 : rows - 2;
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int [,] arr = CreateAndFillArraySpiral();
PrintArray(arr);
