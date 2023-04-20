Console.WriteLine("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = secondNumber * secondNumber;
if(result == firstNumber){
    Console.WriteLine("Yes");
} else {
        Console.WriteLine("No");
}

