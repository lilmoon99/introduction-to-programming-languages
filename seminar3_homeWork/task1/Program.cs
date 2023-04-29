/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int numberEntered = 0;
try
{
    numberEntered = Convert.ToInt32(Console.ReadLine());
    if (numberEntered > 100000 || numberEntered < 9999)
    {
        System.Console.WriteLine("Вы ввели неправильное число!");
    }
}
catch (System.Exception)
{
    System.Console.WriteLine("Вы ввели не число!");
}
System.Console.WriteLine(isPalindrome(numberEntered));

bool isPalindrome(int numberToCheck){
    bool isNumberPalindrome = false;
int [] arrayForNumber = new int [5];
for(int i = 0; i < arrayForNumber.Length;i++){
    arrayForNumber[i] = numberConverter(numberToCheck,i);
    // System.Console.Write(arrayForNumber[i]+" "); //Строка для вывода массива в консоль.
}
for(int i = 0; i < arrayForNumber.Length;i++){
    if(arrayForNumber[i] == arrayForNumber[arrayForNumber.Length - i - 1]){
        isNumberPalindrome = true;
    } else isNumberPalindrome = false;
}
    return isNumberPalindrome;
}

int getFirstRank(int number)
{
    while (number > 9)
    {
        number /= 10;
    }
    return number % 10;
}
int getSecondRank(int number)
{
    while (number > 99)
    {
        number /= 10;
    }
    return number % 10;
}
int getThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
int getFourthRank(int number)
{
    while (number > 9999)
    {
        number /= 10;
    }
    return number % 10;
}
int getFifthRank(int number)
{
    while (number > 99999)
    {
        number /= 10;
    }
    return number % 10;
}

int numberConverter(int number, int flag)
{
    int tempNumber = 0;
    switch (flag)
    {
        case 0:
            tempNumber =getFirstRank(number);
            break;
        case 1:
            tempNumber =getSecondRank(number);
            break;
        case 2:
            tempNumber =getThirdRank(number);
            break;
        case 3:
            tempNumber =getFourthRank(number);
            break;
        case 4:
            tempNumber =getFifthRank(number);
            break;
    }
    return tempNumber;
}