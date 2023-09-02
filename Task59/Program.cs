// 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

using System.Globalization;
using System.Linq.Expressions;

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

int[,] DelMinRowColumn(int[,] matrix)
{
    var setRow = new HashSet<int>();
    var setColumn = new HashSet<int>();

    int min = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                setColumn.Clear();
                setRow.Clear();
            }
            if (min == matrix[i, j])
            {
                setRow.Add(i);
                setColumn.Add(j);
            }
        }
    }

    int row = matrix.GetLength(0) - setRow.Count;
    int column = matrix.GetLength(1) - setColumn.Count;

    var resMatrix = new int[row, column];

    for (int i = 0, ires = 0; i < matrix.GetLength(0); i++)
    {
        if (setRow.Contains(i))
            continue;
        for (int j = 0, jres = 0; j < matrix.GetLength(1); j++)
        {
            if (setColumn.Contains(j))
                continue;
            resMatrix[ires, jres] = matrix[i, j];
            jres++;
        }
        ires++;
    }

    return resMatrix;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

var resArray = DelMinRowColumn(array2d);

PrintMatrix(resArray);