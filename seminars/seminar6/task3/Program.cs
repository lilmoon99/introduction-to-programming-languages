/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

string ConvertToBinary(int number)
{
    string result = "";
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}
System.Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(ConvertToBinary(num));