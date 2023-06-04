/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] GenerateArray(int rows, int columns)
{
    int[,] temp2dArray = new int[rows, columns];
    for (int i = 0; i < temp2dArray.GetLength(0); i++)
    {
        for (int j = 0; j < temp2dArray.GetLength(1); j++)
        {
            temp2dArray[i, j] = new Random().Next(0, 10);
        }
    }
    return temp2dArray;
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] SortArrayEachRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            int temp = 0;
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, array.GetLength(1) - j] > array[i, array.GetLength(1) - j - 1])
                {
                    temp = array[i, array.GetLength(1) - j];
                    array[i, array.GetLength(1) - j] = array[i, array.GetLength(1) - j - 1];
                    array[i, array.GetLength(1) - j - 1] = temp;

                }
            }
        }
    }
    return array;
}

int[,] testArray = GenerateArray(4, 4);
Print2dArray(testArray);
System.Console.WriteLine();
int[,] sortedTestArray = SortArrayEachRow(testArray);
Print2dArray(sortedTestArray);