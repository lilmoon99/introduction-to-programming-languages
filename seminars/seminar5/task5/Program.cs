/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
int[] array = { 1, 2, 3, 4, 5};
int[] array2 = { 6, 7, 3, 6 };
int[] result = MultiplyPairs(array);
System.Console.WriteLine(String.Join(' ', array));
System.Console.WriteLine(String.Join(' ', result));

int[] MultiplyPairs(int[] array)
{
    int tempArrayLength = 0;
    if (array.Length % 2 == 0)
    {
        tempArrayLength = array.Length / 2;
    }
    else
    {
        tempArrayLength = array.Length / 2 + 1;
    }
    int[] tempArray = new int[tempArrayLength];

    for (int i = 0; i < tempArrayLength; i++)
    {
        tempArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
    {
        tempArray[tempArrayLength - 1] = (int)Math.Sqrt(tempArray[tempArrayLength-1]);
        }


    return tempArray;
}