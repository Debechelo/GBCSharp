// 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите колличество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

var array = new int[M];
for (int i = 0; i < M; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int result = CountGreaterThanZero(array);
Console.WriteLine("Количество чисел, больших 0: " + result);

int CountGreaterThanZero(int[] numbers)
{
    int count = 0;

    foreach (int number in numbers)
    {
        if (number > 0)
        {
            count++;
        }
    }
    return count;
}