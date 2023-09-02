// 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int[,,] CreateThreeDimArrayRndInt(int rows, int columns, int width, int min, int max)
{
    int[,,] cube = new int[rows, columns, width];
    Random rnd = new Random();

    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int l = 0; l < cube.GetLength(2); l++)
            {
                cube[i, j, l] = rnd.Next(min, max + 1);
            }
        }
    }
    return cube;
}

void PrintMatrix(int[,,] cube)
{
    Console.WriteLine();
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int l = 0; l < cube.GetLength(2); l++)
            {
                Console.Write($"{cube[i, j, l],5}({i}, {j}, {l})");
            }
        }
        Console.WriteLine();
    }
}


int[,,] array3d = CreateThreeDimArrayRndInt(3, 3, 2, 10, 99);
PrintMatrix(array3d);
Console.WriteLine();