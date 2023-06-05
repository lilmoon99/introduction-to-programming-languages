/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] matrix;
int N;
string answer;

void InputMatrix()
{
    N = int.Parse(Console.ReadLine());
    matrix = new int[N, N];
    for (int y = 0; y < N; y++)
    {
        string[] line = Console.ReadLine().Split();
        for (int x = 0; x < N; x++)
        {
            matrix[y, x] = int.Parse(line[x]);
        }
    }
}

void InputTestMatrix()
{
    N = 5;
    // matrix = new int[5, 5] {
    //     {1,2,3,4,5},
    //     {4,5,6,7,8},
    //     {7,8,9,1,2},
    //     {8,7,6,5,3},
    //     {4,6,7,9,8}};
            matrix = new int[5, 5] {
        {0,0,0,0,0},
        {0,0,0,0,0},
        {0,0,0,0,0},
        {0,0,0,0,0},
        {0,0,0,0,0}};
}

void SpiralePath()
{
    int x = 0;
    int y = 0;
    int sx = 1;
    int sy = 0;
    answer = matrix[y, x].ToString();
    
    matrix[y, x] = -1;
    bool found;
    do
    {
        found = false;
        while (InRange(x + sx, y + sy))
        {
            x += sx;
            y += sy;
            answer += " " + matrix[y, x];
            matrix[y, x] = -1;
            found = true;
        }
        int sxTemp = sx;
        sx = -sy;
        sy = sxTemp;
        System.Console.WriteLine(answer);
        Console.ReadKey();
    } while (found);
}

bool InRange(int x, int y)
{
    if (x < 0 || x >= N) return false;
    if (y < 0 || y >= N) return false;
    if (matrix[y, x] == -1) return false;
    return true;
}

void WriteAnswer()
{
    System.Console.WriteLine(answer);
    System.Console.ReadKey();
}

InputTestMatrix();
SpiralePath();
WriteAnswer();