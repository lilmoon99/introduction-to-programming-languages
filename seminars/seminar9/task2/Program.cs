/*
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
System.Console.WriteLine(RecurSum(45));
int RecurSum(int number){
    if (number == 0){
        return 0;
    } else{
        int sum =+ number % 10;
        return sum + RecurSum(number / 10);
    }
}