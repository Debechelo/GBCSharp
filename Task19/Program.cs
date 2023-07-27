// 19 Напишите программу, которая принимает на вход
//  пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100000 || number < 10000)
{
    Console.Write("Не пятизначное число");
    return;
}

bool res = Palindrome(number);

Console.Write("Является палиндромом: ");
if (res)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");

bool Palindrome(int num)
{
    return num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10;
}