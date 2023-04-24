Random rand = new Random();
int randomNumber = rand.Next(10, 100);
System.Console.WriteLine(randomNumber);
int a = randomNumber / 10;
int b = randomNumber % 10;
if (a > b)
{
    System.Console.WriteLine($"Our number is {randomNumber}. {a} > {b}. Result {a}");
}
else if (a < b)
{
    System.Console.WriteLine($"Our number is {randomNumber}. {b} > {a}. Result {b}");
}
else
{
    System.Console.WriteLine($"Our number is {randomNumber}. {a} = {b}");
}