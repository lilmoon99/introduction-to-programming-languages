Console.WriteLine("Enter the number: ");
string a = Console.ReadLine();
int xa = Convert.ToInt32(a);
if(xa > 99 && xa < 999){
int b = xa%10;
Console.WriteLine(b);
} else {
    Console.WriteLine("You entered wrong number");
}