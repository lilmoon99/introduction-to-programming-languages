/*
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
*/

int[,] FillArray(int row, int column)
{
    int[,] tempArray = new int[row, column];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = new Random().Next(0, 10);
        }
    }
    return tempArray;
}

void Print2dIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

int[] ConvertTo1dArray(int[,] array)
{
    int[] tempArray = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempArray[k] = array[i, j];
            k++;
        }
    }
    return tempArray;
}




int[,] array2d = FillArray(3, 3);
int[] array1d = ConvertTo1dArray(array2d);
Print2dIntArray(array2d);
System.Console.WriteLine(String.Join(',', array1d));
Array.Sort(array1d);
System.Console.WriteLine(String.Join(',', array1d));
// int[] dictionary = UniqueArrayFrom(array1d);
// System.Console.WriteLine(String.Join(',', dictionary));

int count = 0;
int element = array1d[0];
foreach (int i in array1d)
{
    if (i==element) count++;
    else
    {
        
        Console.WriteLine($"Число {element} встечается {count}");
        element=i;
        count =1;
    }

}

Console.WriteLine($"Число {element} встечается {count}");



// int[] UniqueArrayFrom(int[] array)
// {
//     int count = 1;
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         if (array[i] != array[i + 1])
//         {
//             count++;
//         }
//     }
//     int[] uniqueArray = new int[count];
//     for (int i = 0; i < uniqueArray.Length -1; i++)
//     {
//         if(array[i] != array[i+1]){
//             uniqueArray[i] = array[i];
//         }
//         if (array[i] == array[i + 1])
//         {
//             i++;
            
//         }
        

//     }
//     return uniqueArray;
// }




