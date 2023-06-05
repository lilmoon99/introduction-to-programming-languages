/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Размер матрицы С
Строки С = Строки А
Столбцы С = Столбцы В
Произведение двух матриц выполнимо только в случае, если количество столбцов левой матрицы равно количеству строк правой.
Проверку умножения матриц делал на сайте https://function-x.ru/product_of_matrices_calculator.php
*/

int[,] matrixA = GenerateArray(3, 3);
Print2dArray(matrixA);
System.Console.WriteLine();
int[,] matrixB = GenerateArray(3, 4);
Print2dArray(matrixB);
System.Console.WriteLine();
if (matrixA.GetLength(1) != matrixB.GetLength(1))
{
    int[,] matrixC = MatrixMultiply(matrixA, matrixB);
    Print2dArray(matrixC);
}

int[,] GenerateArray(int rows, int columns)
{
    int[,] temp2dArray = new int[rows, columns];
    for (int i = 0; i < temp2dArray.GetLength(0); i++)
    {
        for (int j = 0; j < temp2dArray.GetLength(1); j++)
        {
            temp2dArray[i, j] = new Random().Next(0, 10);
        }
    }
    return temp2dArray;
}
void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
{

    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {

                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];

            }
        }
    }

    return resultMatrix;
}
