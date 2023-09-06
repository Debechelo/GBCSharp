// 67. Напишите программу, которая на вход 
// принимает число и возвращает сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumDigitsOfNumber(number);
Console.Write($"{sum}");

int SumDigitsOfNumber(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigitsOfNumber(num/10);
}