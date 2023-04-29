/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int number = 0;
try
{
    Console.WriteLine("Enter a number: ");
number = Convert.ToInt32(Console.ReadLine());
}
catch (System.FormatException)
{
    System.Console.WriteLine("You entered not a number!");
}
coubFinder(number);




void coubFinder(int number)
{
    if (number > 0)
    {
        for (int i = 0; i < number; i++)
        {
            System.Console.Write(Math.Pow(i + 1, 3) + " ");
        }
    } else {
        for (int i = 0; i < number*(-1); i++)
        {
            System.Console.Write((Math.Pow(i + 1, 3))*(-1) + " ");
        }
    }
}
