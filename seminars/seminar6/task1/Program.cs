/*
Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/


int[] GenerateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(-10, 10);
    }
    return tempArray;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length-1-i] = temp;
    }
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(length);
System.Console.WriteLine($"{String.Join(" ,",array)}");
ReverseArray(array);
System.Console.WriteLine($"{String.Join(" ,",array)}");

