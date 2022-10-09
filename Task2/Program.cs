// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
using static System.Console;
Clear();

Write("Введите число которое нужно найти в массиве: ");
int number = int.Parse(ReadLine()!);
int[,] arr = GetArray();
PrintArray(arr);
SearchArrayPosition(arr, number);

int[,] GetArray()
{
    int[,] array = new int[5,5];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 101);
            
        }
    }
    return array;
}

void SearchArrayPosition(int[,] inArray, int num)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            if(inArray[i,j] == num)
            {
                WriteLine($"Число {num} находится на позиции [{i},{j}]");
                return;
            }
        } 
        
    }
    WriteLine($"{num} -> такого числа в массиве нет");
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
