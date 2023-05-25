/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int number = 10;
System.Console.WriteLine(string.Join(',',Febonachi(number)));

int[] Febonachi(int N){
    int[] febonachiArray = new int[N];
    febonachiArray[0] = 0;
    febonachiArray[1] = 1;
    for (int i = 2; i < febonachiArray.Length; i++)
    {
        febonachiArray[i] = febonachiArray[i-1] + febonachiArray[i-2];
    }
    return febonachiArray;
}