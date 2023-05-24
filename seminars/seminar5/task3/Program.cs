/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да
*/

int[] array = { 6, 7, 19, 345, -3 };
System.Console.WriteLine(String.Join(' ',array));
System.Console.WriteLine(SearchNumber(array,-3));
bool SearchNumber(int[] array, int numberToSearch)
{
    bool isContain = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == numberToSearch){
            isContain = true;
            break;
        }
    }
    return isContain;
}
