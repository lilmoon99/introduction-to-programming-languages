/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет */

Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());



if(firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber){
        System.Console.WriteLine("True");
} else
{
    System.Console.WriteLine("False");
}

// if(Math.Sqrt(firstNumber) == secondNumber || Math.Sqrt(secondNumber) == firstNumber);
// System.Console.WriteLine(Math.Sqrt(secondNumber) == firstNumber);

