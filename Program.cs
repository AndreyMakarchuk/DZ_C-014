﻿// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int counter = 1; counter <= n; counter++)
{
    if (counter % 2 == 0)
    {
        Console.Write($" {counter}");
    }
}

