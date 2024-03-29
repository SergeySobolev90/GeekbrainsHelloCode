﻿// Задача 67
//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"

int m = 1;
int n = 5;

string Recursion(int m, int n)
{
    if (m <= n)
    {
        return $"{m} " + Recursion(m + 1, n);
    }
    else
    {
        return string.Empty;
    }
}

Console.WriteLine($"Задано М = {m}, и N = {n}");
Console.WriteLine();
Console.WriteLine(Recursion(m, n));
