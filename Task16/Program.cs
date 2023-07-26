// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool Square(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

//Console.WriteLine(Square(5, 25) ? "Одно является квадратом другого" : "Ни одн не является квадратом другого");

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Square(number1, number2) ? "Одно является квадратом другого" : "Ни одно не является квадратом другого");

bool result = Square(number1, number2);

if (result)
{
    Console.WriteLine("Одно является квадратом другого");
}
else
{
    Console.WriteLine("Ни одно не является квадратом другого");
}