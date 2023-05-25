/*
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/




int[] CreateSides(string message)
{
    System.Console.WriteLine(message);
        int[] tempArray = new int [3];

    for (int i = 0; i < tempArray.Length; i++)
    {
        System.Console.WriteLine($"Сторона {i+1}: ");
        tempArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return tempArray;
}

bool IsTriangle(int[] array){
    if(array[0] < array[1]+ array[2] && array[1]<array[0] + array[2] && array[2] < array[0]+ array[1]){
        return true;
    } else return false;
}

int[] array = CreateSides("Введите стороны треугольника...");
System.Console.WriteLine(IsTriangle(array));