/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int length = 8;
int[] array = GenerateArray(length);
System.Console.WriteLine($"[{String.Join(',', array)}] -> {SumOfOddElements(array)}");


int[] GenerateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(0, 20);
    }
    return tempArray;
}

int SumOfOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}