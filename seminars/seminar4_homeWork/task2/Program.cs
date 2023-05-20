/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{number} -> {DigitSum(number)}");
 int DigitSum(int arg){
    int result = 0;
    while(arg > 0){
        result = result + arg % 10;
        arg /= 10;
    }
    return result;
 }