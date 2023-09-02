// 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    int len = rows * columns;
    int left = 0, right = columns;
    int up = 1, down = rows;
    int i = 0, j = 0;

    int count = 0;

    while (count < len)
    {
        for (; j < right; j++)
        {
            matrix[i, j] = count;
            count++;
        }
        right--;
        j--;
        i++;
        for (; i < down; i++)
        {
            matrix[i, j] = count;
            count++;
        }
        down--;
        i--;
        j--;
        for (; j >= left; j--)
        {
            matrix[i, j] = count;
            count++;
        }
        left++;
        j++;
        i--;
        for (; i >= up; i--)
        {
            matrix[i, j] = count;
            count++;
        }
        up++;
        i++;
        j++;

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] array2d = CreateSpiralMatrix(4, 4);
PrintMatrix(array2d);
Console.WriteLine();
