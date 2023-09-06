// 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите целое неотрицательное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое неотрицательное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < 0 || N < 0)
{
    Console.Write($"Некоректное входные данные");
    return;
}

int A = Akerman(M, N);
Console.Write($"{A}");

int Akerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (n != 0 && m == 0)
    {
        return Akerman(n - 1, 1);
    }
    else
    {
        return Akerman(n - 1, Akerman(n, m - 1));
    }
}