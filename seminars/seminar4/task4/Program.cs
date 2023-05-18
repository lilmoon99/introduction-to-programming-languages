/*
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
int [] array = randomArrayGenerator();
ArrayPrint1(array);
System.Console.WriteLine();
ArrayPrint2(array);

int [] randomArrayGenerator(){
    int [] tempArray = new int [8];
    Random random = new Random();
    for(int i = 0; i < tempArray.Length;i++){
        tempArray[i] = random.Next(0,2);
    }
    return tempArray;
}

void ArrayPrint1(int [] array){
    for(int i = 0;i < array.Length;i++){
        System.Console.Write(array[i] + " ");
    }
}

void ArrayPrint2(int [] array){
    System.Console.WriteLine(String.Join(" ",array));
    
}
