// 4: Напишите программу, которая 
// принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Наибольшее из трех чисел: ");

// if (a > b)
// {
//     if (a > c)
//         Console.WriteLine(a);
//     else
//         Console.WriteLine(c);
// }
// else
// {
//     if (b > c)
//         Console.WriteLine(b);
//     else
//         Console.WriteLine(c);
// }


int max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;

Console.Write($"Наибольшее из трех чисел: {max}");
