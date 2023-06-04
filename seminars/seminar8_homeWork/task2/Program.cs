/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int MinimalSumRowNumber(int[,] array){
    int [] sumsInRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumsInRow[i] += array[i,j];
        }
    }
    System.Console.WriteLine($"Сумма элементов в строках: {String.Join(',',sumsInRow)}");
    int minimalRowNumber = 0;
    int temp = sumsInRow[0];
    for (int i = 0; i < sumsInRow.Length; i++)
    {
        if(temp > sumsInRow[i]){
            temp = sumsInRow[i];
            minimalRowNumber = i;
        }
    }
    return minimalRowNumber;
}

int [,] testArray = GenerateArray(5,5);
Print2dArray(testArray);
int minRow = MinimalSumRowNumber(testArray);
System.Console.WriteLine($"Строка с наименьшой суммой: {minRow + 1}");