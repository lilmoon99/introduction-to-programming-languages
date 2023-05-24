/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int length = 10;
int[] array = GenerateArray(length);
System.Console.WriteLine($"[{String.Join(',',array)}] -> {EvenNumbersCounter(array)}");



int[] GenerateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(0, 1000);
    }
    return tempArray;
}

int EvenNumbersCounter(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}