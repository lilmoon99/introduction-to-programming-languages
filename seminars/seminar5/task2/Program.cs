/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] array = GenerateArray(10);
System.Console.WriteLine(String.Join(',',array));
for (int i = 0; i < array.Length; i++)
{
    array[i] *= (-1);
}
System.Console.WriteLine(String.Join(',',array));

int[] GenerateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(-10, 11);
    }
    return tempArray;
}