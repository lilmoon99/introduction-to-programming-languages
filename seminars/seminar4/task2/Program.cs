/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

System.Console.WriteLine("Enter a number: ");
int numberEntered = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(numberRank(numberEntered));
int numberRank(int number){
    int counter = 0;
    bool isNotDone = true;
    int rank = 1;
    while(isNotDone){
        if(number > rank){
            rank *= 10;
            counter++;
        }
        else isNotDone = false;
    }
    return counter;
}