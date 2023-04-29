/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


int[] firstPoint = new int[3];
initFirstPoint();

int[] secondPoint = new int[3];
initSecondPoint();

System.Console.WriteLine(vectorDistance(firstPoint,secondPoint));

double vectorDistance(int[] first, int[] second)
{
    return Math.Round(Math.Sqrt(Math.Pow(first[0] - second[0], 2) + Math.Pow(first[1] - second[1], 2) + Math.Pow(first[2] - second[2], 2)),2);
}
void initFirstPoint(){
Console.WriteLine("Enter a coordinates of first point: ");
for (int i = 0; i < firstPoint.Length; i++)
{
    firstPoint[i] = Convert.ToInt32(Console.ReadLine());
}
}
void initSecondPoint(){
Console.WriteLine("Enter a coordinates of second point: ");
for (int i = 0; i < secondPoint.Length; i++)
{
    secondPoint[i] = Convert.ToInt32(Console.ReadLine());
}
}