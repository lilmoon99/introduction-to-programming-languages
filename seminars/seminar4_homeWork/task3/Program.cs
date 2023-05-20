/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
System.Console.WriteLine("Hello user. Now i will create an array with 8 element. You can chill and watch.");

PrintArray(ArrayGenerator());
System.Console.WriteLine(ArrayGenerator()); //Пруфы того, что ArrayGenerator генерит массив...

int[] ArrayGenerator()
{
    int[] tempArray = new int[8];
    Random random = new Random();
    for (int i = 0; i < tempArray.Length; i++){
        tempArray[i] = random.Next(0,101);
    }
    return tempArray;
}

void PrintArray(int [] array){
    System.Console.WriteLine($"{String.Join(',',array)} -> [{String.Join(',',array)}]");//Приятный для глаза вывод информации...
}