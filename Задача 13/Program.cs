// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write ("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int i = 10;
while(i < 1000000000)
{
if(n > 1 && n <100)
{Console.Write ("Третьей цифры нет");
break;}
else if(n > 100 && n < 1000)
{Console.WriteLine(n % 10);
break;}
else if(n > (100*i) && n < (1000*i))
{Console.WriteLine(n % (10*i)/(1*i));
break;}
i = i * 10;
}