/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


double[] AverageInColumns(int[,] array)
{
    double[] tempArray = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(dimension: 1); j++)
    {
        double temp = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            temp = temp + array[i, j];
        }
        tempArray[j] = Math.Round(temp / array.GetLength(0),2);
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
int[,] testArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int[,] testArray2 = FillArray(row:4,column:4);

Print2dIntArray(testArray);
System.Console.WriteLine(String.Join(' ', AverageInColumns(testArray)));

Print2dIntArray(testArray2);
System.Console.WriteLine(String.Join(' ', AverageInColumns(testArray2)));