// 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит
//  число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int pow = Convert.ToInt32(Console.ReadLine());

double res = Powerfully(number, pow);
Console.WriteLine($"Число {number} в степени {pow} = {res}");

double Powerfully(int num, int power)
{
    if (num == 1)
        return 1;

    double p = 1;
    if (power > 0)
        for (int i = 0; i < power; i++)
        {
            p *= num;
        }
    else
    {
        for (int i = power; i < 0; i++)
        {
            p /= num;
        }
    }

    return p;
}
