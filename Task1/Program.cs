// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
using static System.Console;
Clear();

Write("Введите через пробел размер массива (m n): ");
string[] parameter = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
PrintMatrix(GetMatrix(int.Parse(parameter[0]), int.Parse(parameter[1])));

double[,] GetMatrix(int m, int n)
{
    double[,] array = new double[m,n];
    for(int i = 0; i < m; i++)
    {
        int rnd = new Random().Next(-10, 11);
        for(int j = 0; j < n; j++)
        {
            array[i,j] = new Random().NextDouble() * rnd;
        }
    }
    return array;
}

void PrintMatrix(double[,] inMatrix)
{
    for(int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{Math.Round(inMatrix[i,j], 1)} ");
        }
        WriteLine();
    }
}
