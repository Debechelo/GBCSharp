// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int res = CompositionNumbers(3);

int CompositionNumbers(int num)
{
    int composition = 1;
    while (num != 0)
    {
        checked
        {
            composition *= num;
            num--;
        }

    }
    return composition;
}