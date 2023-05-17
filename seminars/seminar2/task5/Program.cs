/*Задача №14.
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/

System.Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDiv = 7;
int secondDiv = 23;
if(number % firstDiv == 0 && number% secondDiv == 0){
    System.Console.WriteLine("True");
} else
{
    System.Console.WriteLine("False");
}