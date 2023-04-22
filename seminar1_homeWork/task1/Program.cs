/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("We will compare two numbers!");
Console.Write("Enter first number: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(first_number > second_number){
    max = first_number;
}else{
    max = second_number;
}
    Console.WriteLine("max is: " + max);
