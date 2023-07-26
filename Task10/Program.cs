// 10: Напишите программу, которая принимает
//  на вход трёхзначное число и 
//  на выходе показывает вторую цифру этого числа.
//  456 -> 5
//  782 -> 8
//  918 -> 1

Console.Write("Введите трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = SecondDigit(number);
if (res == -1)
    Console.WriteLine("Число не трехзначное");
else
    Console.WriteLine($"Вторая цифра числа: {res}");

    
int SecondDigit(int num)
{
    if (num < 0)
        num *= -1;

    if (num >= 100 && num <= 999)
    {
        int result = num / 10 % 10;
        return result;
    }
    else return -1;

}