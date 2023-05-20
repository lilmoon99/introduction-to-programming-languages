/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
System.Console.WriteLine("Enter a first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter a second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{firstNumber}, {secondNumber} -> {Pow(firstNumber,secondNumber)}");

double Pow(int a,int b){
    return Math.Pow(a,b);
}