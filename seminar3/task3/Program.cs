﻿/*
Задача №22. Работа в группах
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number;i++){
    System.Console.Write(i*i + " ");
}