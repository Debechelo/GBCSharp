// 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M <= 0 || N <= 0)
{
    Console.Write($"Некоректное входные данные");
    return;
}

if (M > N)
{
    (M, N) = (N, M);
}

int sum = RangeSum(M, N);
Console.Write($"{sum}");

int RangeSum(int m, int n)
{
    if (n == m - 1) return 0;
    return n + RangeSum(m, n - 1);
}