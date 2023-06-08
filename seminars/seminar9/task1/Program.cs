/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/
// RecurMethod(4,8);
void RecurMethod(int fromN, int toN)
{
    for (int i = fromN; i <= toN; i++)
    {
        System.Console.Write($"{i} ");
    }
}
void rec(int start, int end)
{
    if (start == end) return;
    else
    {
        Console.Write(start + " ");
        start++;
        rec(start, end);
    }
}
rec(4, 8);

string Recur(int start,int end){
    if (start == end) { 
        return start.ToString();
    } else return (start + Recur(start + 1,end));
}