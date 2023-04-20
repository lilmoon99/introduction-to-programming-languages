internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int ourNumber = Convert.ToInt32(Console.ReadLine());
        int startPoint = 0;
        int endPoint = 0;
        if (ourNumber > 0)
        {
            startPoint = ourNumber * -1;
            endPoint = ourNumber;
        }
        else if (ourNumber < 0)
        {
            startPoint = ourNumber;
            endPoint = ourNumber * -1;
        }
        else
        {
            Console.WriteLine("You entered 0!");
        }
        while (startPoint <= endPoint)
        {
            Console.Write(startPoint + " ");
            startPoint++;
        }
    }
}
/*string a = Console.ReadLine();
int xa = Convert.ToInt32(a);
int b = xa%10;
Console.WriteLine(b);*/