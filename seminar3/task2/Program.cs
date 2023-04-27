/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter > 4)
{
    System.Console.WriteLine("You entered wrong quarter!");
}
switch (quarter)
{
    case 1:
        System.Console.WriteLine("X > 0, Y > 0");
        break;
    case 2:
        System.Console.WriteLine("X > 0, Y < 0");
        break;
    case 3:
        System.Console.WriteLine("X < 0, Y < 0");
        break;
    case 4:
        System.Console.WriteLine("X < 0, Y > 0");
        break;
}