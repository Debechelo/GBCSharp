// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int Remains(int num1, int num2)
{
    return num1 % num2;
}

void Multiplicity(int num1, int num2)
{
    int res = Remains(num1, num2);
    Console.WriteLine(res == 0 ? "кратно" : $"не кратно, остаток {res}");
}

Multiplicity(120, 34);
Multiplicity(16, 4);
Multiplicity(34, 5);

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Multiplicity(number1, number2);


// int res = Remains(120, 34);
// Console.WriteLine(res == 0 ? "кратно" : $"не кратно, остаток {res}");

// int res1 = Remains(16, 4);
// Console.WriteLine(res1 == 0 ? "кратно" : $"не кратно, остаток {res1}");

// int res2 = Remains(34, 5);
// Console.WriteLine(res2 == 0 ? "кратно" : $"не кратно, остаток {res2}");