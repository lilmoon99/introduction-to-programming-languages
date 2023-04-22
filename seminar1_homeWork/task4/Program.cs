/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
bool is_need_launch_more = true;
int number = 0;
while (is_need_launch_more)
{
    try
    {
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        is_need_launch_more = false;
    }
    catch
    {
        FormatException exception;
        Console.WriteLine("You entered not a number. Please try again ...");
    }
}
for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}