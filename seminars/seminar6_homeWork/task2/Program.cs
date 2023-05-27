/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
const int X = 0;
const int Y = 1;

double[] InitLine(int lineNumber)
{
    double[] tempArray = new double[2];
    System.Console.WriteLine($"Enter b{lineNumber} for {lineNumber} line: ");
    tempArray[X] = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine($"Enter k{lineNumber} for {lineNumber} line: ");
    tempArray[Y] = Convert.ToDouble(Console.ReadLine());
    return tempArray;
}

double[] FindCoordinates(double[] arg1, double[] arg2)
{
    double[] coordinates = new double[2];
    coordinates[X] = -(arg1[0] - arg2[0]) / (arg1[1] - arg2[1]);
    coordinates[Y] = arg1[1] * coordinates[X] + arg1[0];
    return coordinates;
}

bool Validation(double[] arg1, double[] arg2)
{
    if (arg1[0] == arg2[0])
    {
        if (arg1[1] == arg2[1])
        {
            System.Console.WriteLine("Прямые совпадают.");
            return false;
        }
        else
        {
            System.Console.WriteLine("Прямые параллельны.");
            return false;
        }
    }
    return true;
}

double[] line1 = InitLine(1);
double[] line2 = InitLine(2);
if (Validation(line1, line2))
{
    double[] crossCoordinates = FindCoordinates(line1, line2);
    System.Console.WriteLine($"Lines are crossing at ({crossCoordinates[X]};{crossCoordinates[Y]})");
}


