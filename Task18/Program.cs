﻿// 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.Write("Введите номер четверти: ");
string? numberQuarter = Console.ReadLine();

string? range = "";

if(numberQuarter != null)
    range = RangeQuarter(numberQuarter);

if (range != null) 
    Console.WriteLine(range);
else Console.WriteLine("Некорректная четверть"); 

string? RangeQuarter (string numQuarter)
{
    if(numQuarter == "1") return "x > 0, y > 0";
    if(numQuarter == "2") return "x < 0, y > 0";
    if(numQuarter == "3") return "x < 0, y < 0";
    if(numQuarter == "4") return "x > 0, y < 0";
    return null;
}