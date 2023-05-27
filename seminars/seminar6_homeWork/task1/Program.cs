System.Console.WriteLine("Enter a numbers.For example: 1,2,3,4,5,6");
string numbers = Console.ReadLine();
bool IsNotANumber = false;
string[] arrayOfStr = numbers.Split(',',' ','.','/','|');
int[] numbersArray = CopyToIntArray(arrayOfStr);

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
        }
        if (IsNotANumber)
        {
            break;
        }
    }
    return tempArray;
}

if (IsNotANumber == false)
{
    System.Console.WriteLine($"{String.Join('|', CopyToIntArray(arrayOfStr))}");
    NumbersGreaterThanZero(numbersArray);
}


void NumbersGreaterThanZero(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    System.Console.WriteLine($"There is {counter} numbers greater than zero(0).");
}



