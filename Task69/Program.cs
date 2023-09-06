// 67. Напишите программу, которая на вход принимает число
// два числа A и B, и возводит число А в целую степень В с помощью рекурсии
// A = 3, B = 5 -> 243

Console.Write("Введите целое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int B = Convert.ToInt32(Console.ReadLine());

int pow = PowNum(A, B);
Console.Write($"{pow}");

int PowNum(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * PowNum(numA, numB - 1);
}