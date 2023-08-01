// 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigit(number);
Console.WriteLine($"Количество цифр в числе {number} = {result}");

int SumDigit(int num)
{
    if(num < 0) 
        num *= -1;

    int sumDigit = 0;

    while (num != 0)
    {
        sumDigit += num % 10;
        num = num / 10;
    }
    return sumDigit;
}