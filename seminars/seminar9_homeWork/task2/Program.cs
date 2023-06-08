/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumFromMToN(int M, int N)
{
    if (M > N) return 0;
    else
    {
        return (M + SumFromMToN(M + 1, N));
    }
}

int InitNumber(string arg)
{
    System.Console.WriteLine($"Enter {arg}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int M = InitNumber("M");
int N = InitNumber("N");
System.Console.WriteLine($"Result of adding numbers from {M} to {N} is {SumFromMToN(M, N)}");