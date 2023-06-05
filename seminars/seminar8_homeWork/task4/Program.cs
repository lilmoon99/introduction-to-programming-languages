/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// int[,] matrix;
// int N;
// string answer;

// void InputMatrix()
// {
//     N = int.Parse(Console.ReadLine());
//     matrix = new int[N, N];
//     for (int y = 0; y < N; y++)
//     {
//         string[] line = Console.ReadLine().Split();
//         for (int x = 0; x < N; x++)
//         {
//             matrix[y, x] = int.Parse(line[x]);
//         }
//     }
// }

// void InputTestMatrix()
// {
//     N = 5;
//     // matrix = new int[5, 5] {
//     //     {1,2,3,4,5},
//     //     {4,5,6,7,8},
//     //     {7,8,9,1,2},
//     //     {8,7,6,5,3},
//     //     {4,6,7,9,8}};
//             matrix = new int[5, 5] {
//         {0,0,0,0,0},
//         {0,0,0,0,0},
//         {0,0,0,0,0},
//         {0,0,0,0,0},
//         {0,0,0,0,0}};
// }

// void SpiralePath()
// {
//     int x = 0;
//     int y = 0;
//     int sx = 1;
//     int sy = 0;
//     answer = matrix[y, x].ToString();

//     matrix[y, x] = -1;
//     bool found;
//     do
//     {
//         found = false;
//         while (InRange(x + sx, y + sy))
//         {
//             x += sx;
//             y += sy;
//             answer += " " + matrix[y, x];
//             matrix[y, x] = -1;
//             found = true;
//         }
//         int sxTemp = sx;
//         sx = -sy;
//         sy = sxTemp;
//         System.Console.WriteLine(answer);
//         Console.ReadKey();
//     } while (found);
// }

// bool InRange(int x, int y)
// {
//     if (x < 0 || x >= N) return false;
//     if (y < 0 || y >= N) return false;
//     if (matrix[y, x] == -1) return false;
//     return true;
// }

// void WriteAnswer()
// {
//     System.Console.WriteLine(answer);
//     System.Console.ReadKey();
// }

// InputTestMatrix();
// SpiralePath();
// WriteAnswer();

// 
// 
// 
System.Console.WriteLine("Enter a size of matrix: ");
int m_size = int.Parse(Console.ReadLine());
int[,] matrix = new int[m_size, m_size];
System.Console.WriteLine("Enter a start number: ");
int currentCount = int.Parse(Console.ReadLine());
DrawSpiral();
PrintMatrix();
void DrawSpiral()
{
    //x,y   x, y+size-1
    //x+1, y+size-1     x+size-1, y+size-1
    //x+size-1, y+size-2    x+size-1, y
    //x+size-2, y   x+1, y
    int x = 0, y = 0, size = m_size;

    while (size > 0)
    {
        for (int i = y; i <= y + size - 1; i++)
        {
            matrix[x, i] = currentCount++;
        }

        for (int j = x + 1; j <= x + size - 1; j++)
        {
            matrix[j, y + size - 1] = currentCount++;
        }

        for (int i = y + size - 2; i >= y; i--)
        {
            matrix[x + size - 1, i] = currentCount++;
        }

        for (int i = x + size - 2; i >= x + 1; i--)
        {
            matrix[i, y] = currentCount++;
        }

        x = x + 1;
        y = y + 1;
        size = size - 2;
    }
}
void PrintMatrix()
{
    for (int i = 0; i < m_size; i++)
    {
        for (int j = 0; j < m_size; j++)
        {
            Console.Write(String.Format("{0,3}", matrix[i, j]));
        }
        Console.WriteLine();
    }
}