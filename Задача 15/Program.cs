// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблиись!\nВведите номер дня недели: ");
    n = int.Parse(Console.ReadLine()!);
}
if (n > 5 && n < 8)
    Console.WriteLine("Да выходной");
else
    Console.WriteLine("Нет рабочий");