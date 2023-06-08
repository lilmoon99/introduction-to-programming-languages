/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

bool ValidateNumber(int N)
{
    if (N < 0)
    {
        System.Console.WriteLine($"{N} is negative.");
        return false;
    }else if(N == 0){
        System.Console.WriteLine($"{N} is zero.");
        return false;
    }
    else return true;
}

string FromNToOne(int N)
{
    if (N == 1) return N.ToString();
    else
    {
        return (N + "," + FromNToOne(N - 1));
    }
}

System.Console.WriteLine("Enter a positive number: ");
int number = int.Parse(Console.ReadLine());
if (ValidateNumber(number))
{
    System.Console.WriteLine(FromNToOne(number));
}