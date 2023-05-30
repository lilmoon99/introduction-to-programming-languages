/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double RandomDoubleInRange(double min, double max)
{
    Random rand = new Random();
    double range = max - min;
    double sample = rand.NextDouble();
    return (sample * range) + min;
}

double[,] FillDoubleArray(int row, int column)
{
    double[,] tempArray = new double[row, column];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = RandomDoubleInRange(min: 0, max: 9);
            tempArray[i,j] = Math.Round(tempArray[i,j],1);
        }
    }
    return tempArray;
}

void Print2dDoubleArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}  ");
        }
        System.Console.WriteLine();
    }
}

int row = 4;
int column = 4;
Print2dDoubleArray(FillDoubleArray(row,column));


