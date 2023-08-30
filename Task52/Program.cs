// 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    // 0 1
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        // Console.WriteLine(" |");
        Console.WriteLine();
    }
}

double[] MeanOfColumn(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    double[] meanArray = new double[columns];

    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            meanArray[i] += matrix[j, i];
        }
        meanArray[i] /= rows;
    }

    return meanArray;
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);

double[] mnMtrx = MeanOfColumn(array2d);

int columns = array2d.GetLength(1);

Console.Write("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < columns; i++)
{
    Console.Write($"{mnMtrx[i],5:f2}; ");
}


