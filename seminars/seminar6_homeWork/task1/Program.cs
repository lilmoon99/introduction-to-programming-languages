/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

System.Console.WriteLine("Enter a numbers.For example: 1,2,3,4,5,6");
string numbers = Console.ReadLine();
bool IsNotANumber = false;
string[] arrayOfStr = numbers.Split(',', ' ', '.', '/', '|');
int[] numbersArray = CopyToIntArray(arrayOfStr);

if (!IsNotANumber)
{
    System.Console.WriteLine($"{String.Join('|', CopyToIntArray(arrayOfStr))}");
    System.Console.WriteLine($"There is {NumbersGreaterThanZero(numbersArray)} numbers greater than zero(0).");
}

int[] CopyToIntArray(string[] array)
{
    int[] tempArray = new int[array.Length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        try
        {
            tempArray[i] = Convert.ToInt32(array[i]);
        }
        catch (FormatException)
        {
            System.Console.WriteLine($"{array[i]} is not a number.Please try again.");
            IsNotANumber = true;
            break;
        }

    }
    return tempArray;
}


int NumbersGreaterThanZero(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}



