/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

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

int GenerateNumber()
{

    int temp = new Random().Next(0, 100);
    return temp;
}

int[,] PowEvenElemets(int[,] array){
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 1 && j % 2 ==1){
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }
    return array;
}

int row = 3;
int column = 4;
int[,] ourArray = FillArray(row,column);
PrintArray(ourArray);
System.Console.WriteLine();
PrintArray(PowEvenElemets(ourArray));


