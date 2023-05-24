/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Диапазон [-10, 10]. Обратите внимание на вещественных чисел
Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76
*/
int length = 10;
double[] array = GenerateArray(length);
System.Console.WriteLine($"[{String.Join('|', array)}] -> {MaxMinSub(array)}");

double[] GenerateArray(int length)
{
    double[] tempArray = new double[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = RandomDoubleInRange(-10, 10);
        tempArray[i] = Math.Round(tempArray[i], 2);
    }
    return tempArray;
}
double RandomDoubleInRange(double min, double max)
{
    Random rand = new Random();
    double range = max - min;
    double sample = rand.NextDouble();
    return (sample * range) + min;
}

double MaxMinSub(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if(minValue > array[j]) minValue = array[j];
        }
        if(maxValue < array[i]) maxValue = array[i];
    }
    System.Console.WriteLine($"max = {maxValue},min = {minValue}");
    return maxValue - minValue;
}

