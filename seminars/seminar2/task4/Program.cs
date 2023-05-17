/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно

Задача №14.
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/
System.Console.WriteLine("Enter a first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter a second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber % secondNumber == 0 || secondNumber % firstNumber == 0){
    System.Console.WriteLine("True");
} else {
        System.Console.Write($"False. ");
    if (firstNumber > secondNumber)
    {
        System.Console.WriteLine(firstNumber % secondNumber);
    } else
    {
        System.Console.WriteLine(secondNumber % firstNumber);
    }

}