﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ValueNumber()
{
    Console.Write("Введите любое число от 1: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
        Console.WriteLine(" ");
    }
}
ValueNumber();