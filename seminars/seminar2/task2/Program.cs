/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
Random rand = new Random();
int number = rand.Next(100,1000);
System.Console.WriteLine(number);

int firstNumber = number / 100;
int lastNumber = number % 10;
System.Console.WriteLine($"Result is: {firstNumber} {lastNumber}");