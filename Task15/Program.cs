// 15: Напишите программу, которая принимает
//  на вход цифру, обозначающую день недели, 
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите целое число: ");
int d = Convert.ToInt32(Console.ReadLine());

Weekend(d);

void Weekend(int day)
{
    if (day < 1 || day > 7)
        Console.Write("Ошибка");
    else if (day > 0 && day < 6)
        Console.Write("Нет");
    else Console.Write("Да");
}