// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool Multiplicity7and23(int num) // false, true =bool
{
    return num % 7 == 0 && num % 23 == 0;
}


//Console.WriteLine(Multiplicity7and23(32) ? "Кратно 7 и 23" : "Не кратно 7 либо 23");

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multiplicity7and23(number) ? "Кратно 7 и 23" : "Не кратно 7 либо 23");