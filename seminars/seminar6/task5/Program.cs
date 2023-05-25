/*
Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.
*/
System.Console.WriteLine("Enter a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] generatedArray = GenerateArray(length);
System.Console.WriteLine($"{String.Join(',',generatedArray)} -> generated array");
int[] copiedArray = CopyArray(generatedArray);
System.Console.WriteLine($"{String.Join(',',copiedArray)} -> copied array");


int[] GenerateArray(int length){
    int[] tempArray = new int[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(0,100);
    }
    return tempArray;
}

int[] CopyArray(int[] array){
    int[] tempArray = new int[array.Length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = array[i];
    }
    return tempArray;
}