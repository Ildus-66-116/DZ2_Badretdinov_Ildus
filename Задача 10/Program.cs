﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите 3 значное число: ");
int n = int.Parse(Console.ReadLine()!);
while(n < 100 || n > 999)
{
    Console.Write ("Вы ошиблись! \nВведите 3 значное число: ");
    n = int.Parse(Console.ReadLine()!);
}
Console.WriteLine(n % 100/10);