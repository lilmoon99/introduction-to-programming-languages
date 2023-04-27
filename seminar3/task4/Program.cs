/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Enter cordinates of first point: ");
int[] firstPoint = new int[2];
int[] secondPoint = new int[2];

for (int i = 0; i < firstPoint.Length; i++)
{
    firstPoint[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Enter cordinates of second point: ");
for (int i = 0; i < secondPoint.Length; i++)
{
    secondPoint[i] = Convert.ToInt32(Console.ReadLine());
}
int numberForSqrt = (secondPoint[0] - firstPoint[0])*(secondPoint[0] - firstPoint[0]) + (secondPoint[1] - firstPoint[1])*(secondPoint[1] - firstPoint[1]);
double numberForSqrt2 = Math.Pow((double)secondPoint[0] - (double)firstPoint[0],2.0) + Math.Pow((double)secondPoint[1] - (double)firstPoint[1],2.0);
double distanse = Math.Sqrt(numberForSqrt2);

System.Console.WriteLine(Math.Round(distanse,3));