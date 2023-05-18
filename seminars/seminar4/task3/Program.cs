/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/
System.Console.WriteLine("Enter a number: ");
int numberEntered = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Multiply(numberEntered));
int Multiply(int number){
    int result = 1;
    for(int i = 1; i <= number;i++){
        result *= i;
    }
    return result;
}