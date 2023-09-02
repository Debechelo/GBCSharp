// 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
        return null;

    int row = matrix1.GetLength(0);
    int column = matrix2.GetLength(1);
    int len = matrix1.GetLength(1);

    int[,] multMatrix = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            int sum = 0;
            for (int l = 0; l < len; l++)
            {
                sum += matrix1[i, l] * matrix2[l, j];
            }

            multMatrix[i, j] = sum;
        }
    }

    return multMatrix;
}

int[,] array2d1 = CreateMatrixRndInt(3, 2, 1, 9);
PrintMatrix(array2d1);
Console.WriteLine();

int[,] array2d2 = CreateMatrixRndInt(2, 3, 1, 9);
PrintMatrix(array2d2);
Console.WriteLine();

int[,] array = MultiplyMatrix(array2d1, array2d2);

if (array == null)
{
    Console.WriteLine("Невозможно перемножить матрицы");
}
else
{
    PrintMatrix(array);
}