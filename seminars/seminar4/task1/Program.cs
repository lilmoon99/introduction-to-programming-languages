/*Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
System.Console.WriteLine("Enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{a} -> {Sum(a)}");

int Sum(int a){
    int result = 0;
    for(int i = 0;i <= a;i++){
        result += i;
    }
    return result;
}
