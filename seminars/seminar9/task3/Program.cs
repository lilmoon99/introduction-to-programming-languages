/*
Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int RecurPow(int a,int b){
    if(b <= 0){
        return 1;
    } else {
        int result = a ;
        b--;
        return result * RecurPow(a,b);
    }
}
System.Console.WriteLine(RecurPow(2,10));