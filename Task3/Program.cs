//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using static System.Console;
Clear();

int[,] arr = GetArray(5,5);
PrintArray(arr);
GetCount(arr);

int[,] GetArray(int coulumn, int line)
{
    int[,] array = new int[coulumn,line];
    for (int i = 0; i < coulumn; i++)
    {
        for (int j = 0; j < line; j++)
        {
            array[i,j] = new Random().Next(0, 101);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
    WriteLine();
}

void GetCount(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        double result = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result += inArray[j,i];
        }
        WriteLine($"Средне арифмитическое столбца {i + 1} -> {Math.Round(result/inArray.GetLength(0), 2)}");
    }
}
