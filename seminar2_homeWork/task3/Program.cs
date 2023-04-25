/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter a day number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 7 || dayNumber < 1)
{
    System.Console.WriteLine("You entered wrong day number. Please enter a number from 1 to 7.");
}
else if (dayNumber > 5 && dayNumber <= 7)
{
    System.Console.WriteLine("It's time to chill, bro!");
} else {
    System.Console.WriteLine("You have to wake up and go to work,looser!");
}

