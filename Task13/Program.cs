// 13: Напишите программу, которая выводит третью
//  цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = ThirdDigit(num);
if (res == -1)
    Console.WriteLine("Нет третьей цифры");
else
    Console.WriteLine($"Третья цифра числа: {res}");

int ThirdDigit(int number)
{
    if (number < 0)
        number *= -1;

    if (number < 100)
        return -1;

    while (number > 1000)
    {
        number /= 10;
    }

    int result = number % 10;
    return result;
}