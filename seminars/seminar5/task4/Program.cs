/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
int arrayLength = 123;
int min = 10;
int max = 99;

int[] array = GenerateArray(arrayLength);
System.Console.WriteLine(string.Join(',',array));
System.Console.WriteLine(numberInDiapozone(array));


int[] GenerateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(0,1000);
    }
    return tempArray;
}

int numberInDiapozone(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) counter++;
    }
    return counter;
}