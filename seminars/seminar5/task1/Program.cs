/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] array = GenerateArray();
int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) sumPositive += array[i];
    else sumNegative += array[i];
}
System.Console.WriteLine(String.Join(',',array));
System.Console.WriteLine($"Сумма положительных чисел: {sumPositive}");
System.Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}");


int[] GenerateArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}