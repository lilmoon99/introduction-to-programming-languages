/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int divider = 1000;
int counter = 0;
if(number < 0){
    number = number * (-1);
}
if (number < 99)
{
    System.Console.WriteLine("You dont have third digit on your number.");
} 
else{
while (number > divider) // определяем к какому промежутку чисел принадлежит число 
{
    divider = divider * 10;
    counter++;
}
for (int i = 0; i < counter;i++){ // делаем number трехзначным
    number = number / 10;
}
System.Console.WriteLine(number % 10); // находим последнее число
}
