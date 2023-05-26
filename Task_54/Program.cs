// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void SortMassiveMaxMin(int [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(1)-1; k++)
            {
                if(massive [i,k] < massive [i,k+1])
                {
                    int temp = massive [i,k+1];
                    massive [i,k+1] = massive [i,k];
                    massive [i,k] = temp;
                }
            }
        }
    }
}


int [,] massive =CreateArray();
ShowArr(massive);
SortMassiveMaxMin(massive);
ShowArr(massive);
