﻿/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

uint AckermannFunction(uint m,uint n){
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunction(m-1,1);
    else return AckermannFunction(m-1,AckermannFunction(m,n-1));
}
uint arg1 = 3;
uint arg2 = 5;
System.Console.WriteLine($"Result of Ackermann function work for m = {arg1}, n = {arg2} is {AckermannFunction(arg1,arg2)}");