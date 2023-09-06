// 65. Задайте значения M и N. Напишите программу которая
// которая выведет все натуральные числа от M до N.
// M = 2, N = 5 -> "2, 3, 4, 5"

Console.Write("Введите натуральное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N){
    (M, N) = (N, M);
}

RangNaturalNumber(M, N);

void RangNaturalNumber(int m, int n)
{
    if (n == m-1) return;
    RangNaturalNumber(m, n - 1);
    Console.Write($"{n} ");
}