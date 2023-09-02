// 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int minRowSum(int[,] matrix) {
    int min = int.MaxValue;
    int minRow = 0;

    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        int sumRow = 0;
        for (int j = 0; j < column; j++)
        {
            sumRow += matrix[i,j];
        }
        if(min > sumRow) {
            min = sumRow;
            minRow = i;
        }        
    }

    return minRow;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

int mnR = minRowSum(array2d);

Console.Write($"Строка с наименьшей суммой элементов: {mnR + 1}");