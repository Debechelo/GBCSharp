// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999: {number}");


int result = DeleteSecondDigit(number);
Console.WriteLine($"Результат удаление второй цифры: {result}");


int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100; 
    int thirdDigit = num % 10;

    return firstDigit * 10 + thirdDigit;
}