// 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
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

void SortRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        SortInRow(matrix, i);
    }
}

void SortInRow(int[,] matrix, int row)
{
    int length = matrix.GetLength(1);

    for (int i = 1; i < length; i++)
    {
        int temp =  matrix[row, i];

        for (int j = i - 1; j >= 0; j--)
        {
            if(matrix[row, j] > temp) 
                break;
            matrix[row, j+1] = matrix[row,j];
            matrix[row, j] = temp;
        }
    }
}

int[,] array2d = CreateMatrixRndInt(4, 5, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

SortRows(array2d);
PrintMatrix(array2d);