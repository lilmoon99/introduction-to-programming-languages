/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Even or odd? Let's check!");
int numberToCheck = 0;
bool isNotDone = true;
while (isNotDone)
{
    try
    {
        Console.Write("Enter a number: ");
        string readLine = Console.ReadLine();
        numberToCheck = Convert.ToInt32(readLine);
        isNotDone = false;
    }
    catch
    {
        FormatException exception;
        Console.WriteLine("You entered not a number. Please try again...");
    }
}
if (numberToCheck % 2 == 0)
{
    Console.WriteLine("Your number is even.");
}
else
{
    Console.WriteLine("Your number is odd.");
}