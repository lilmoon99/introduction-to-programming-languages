/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("We will compare three numbers!");
bool is_need_launch_more = true;
while (is_need_launch_more)
{
    try
    {
        Console.Write("Enter first number: ");
        int first_number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second_number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int third_number = Convert.ToInt32(Console.ReadLine());
        int max = first_number;
        if (second_number > max)
        {
            max = second_number;
        }
        if (third_number > max)
        {
            max = third_number;
        }
        Console.WriteLine("Max is: " + max);
        is_need_launch_more = false;
    }
    catch
    {
        FormatException exception;
        Console.WriteLine("You entered not a number. Please try again ...");
    }
}