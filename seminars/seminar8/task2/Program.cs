/*
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int[,] FillArray(int row, int column)
{
    int[,] tempArray = new int[row, column];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = new Random().Next(0,10);
        }
    }
    return tempArray;
}

void Print2dIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

int row = 4;
int column = 4;
int [,] array1 = FillArray(row,column);
int [,] array2 = new int [array1.GetLength(0),array1.GetLength(1)];
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array2[i,j] = array1[j,i];
    }
}

Print2dIntArray(array1);
System.Console.WriteLine();
Print2dIntArray(array2);