/*
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

int GenerateNumber()
{

    int temp = new Random().Next(0, 100);
    return temp;
}

int[,] FillArray(int row, int column)
{
    int[,] tempArray = new int[row, column];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = GenerateNumber();
        }
    }
    return tempArray;
}

void PrintArray(int[,] array){
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
int row = 3;
int column = 4;
int[,] ourArray = FillArray(row,column);
PrintArray(ourArray);