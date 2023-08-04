// 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным
//  и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

void PrintArray(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], round);

        Console.Write(roundNum);
        if (i < arr.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

double DiffMinMax(double[] arr)
{
    if (arr.Length == 0)
        return 0;

    double min = arr[0];
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }

    return max - min;
}

double[] array = CreateArrayRndDouble(10, 0, 99);
PrintArray(array);

double result = DiffMinMax(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {Math.Round(result, 2)}");