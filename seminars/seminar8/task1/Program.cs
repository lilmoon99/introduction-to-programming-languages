/*
Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

int[,] array = {{1,5,2,5},
                {1,23,5,2},
                {1,2,5,7},
                {8,3,2,6}};

int[,] ReplaceFirstAndLastRow(int[,] array)
{
    // int[,] tempArray = new int[array.GetLength(0),array.GetLength(1)];
    int[] tempRow = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                tempRow[j] = array[i, j];
            }
        }
        if(i==3){
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[0,j] = array[i,j];
            }
        }
    }

    for (int i = 3; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = tempRow[j];
        }
    }
        return array;
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
Print2dIntArray(array);
Print2dIntArray(ReplaceFirstAndLastRow(array));