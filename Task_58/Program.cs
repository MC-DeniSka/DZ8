// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] CreateArray(int minValue = 1,int maxValue = 9)
{
    System.Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов");
    int colomns = Convert.ToInt32(Console.ReadLine());
    if (rows > 0 && colomns > 0)
    {
        int [,] massive = new int [rows,colomns];
        var rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colomns; j++)
            {
                massive [i,j] = rnd.Next(minValue,maxValue+1);
            }
        }
        return massive;
    }
    else
    {
        System.Console.WriteLine("Ошибка - введите целое положительное число");
        int [,] massive = new int [0,0];
        return massive;
    }

}


void ShowArr(int [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write(massive [i,j]+ " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void MultiplyArray(int [,] firstArray, int [,] secondArray, int [,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray [i,k] * secondArray [k,j];
            }
            resultArray [i,j] = sum;
        }
    }
}

int [,] firstArray = CreateArray();
int [,] secondArray = CreateArray();
int [,] resultArray = new int [2,2];
ShowArr(firstArray);
ShowArr(secondArray);
MultiplyArray(firstArray,secondArray,resultArray);
ShowArr(resultArray);