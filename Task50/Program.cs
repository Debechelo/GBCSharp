// 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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

// int GetElement(int[,] matrix, int i, int j)
// {
//     return matrix[i, j];
// }

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);

Console.Write("Введите первый индекс: ");
int index1 = int.Parse(Console.ReadLine());

Console.Write("Введите второй индекс: ");
int index2 = int.Parse(Console.ReadLine());

if (index1 < array2d.GetLength(0) && index2 < array2d.GetLength(1))
    Console.WriteLine($"Результат: {array2d[index1, index2]}");
else Console.WriteLine($"{index1},{index2} -> такого элемента в массиве нет");