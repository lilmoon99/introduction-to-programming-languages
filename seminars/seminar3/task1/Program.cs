/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
Console.WriteLine("Enter a cordinates X and Y: ");

int[] points = new int[2];

for (int i = 0; i < points.Length; i++)
{
    points[i] = Convert.ToInt32(Console.ReadLine());

}

if (points[0] > 0 && points[1] > 0)
{
    System.Console.WriteLine("Точка в I четверти.");
}
else if (points[0] > 0 && points[1] < 0)
{
    System.Console.WriteLine("Точка в II четверти.");
}
else if (points[0] < 0 && points[1] < 0)
{
    System.Console.WriteLine("Точка в III четверти.");
}
else if (points[0] < 0 && points[1] > 0)
{
    System.Console.WriteLine("Точка в IV четверти.");
} else {
    System.Console.WriteLine("X = 0 or Y=0");
}