


int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 {number}");
Console.WriteLine($"Наибольшее цифра числа -> {MaxDigit(number)}");


// int firstDigit = number / 10;
// int secondDigit = number / 10;

// Console.Write("Наибольшее цифра числа -> ");

// if (firstDigit > secondDigit) Console.WriteLine(firstDigit);
// else Console.WriteLine(secondDigit);

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;


int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}