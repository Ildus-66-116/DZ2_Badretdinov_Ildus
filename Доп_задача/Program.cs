// Дополнительная задача
// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

// Входные данные
// Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. 
// Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.

// В выходной файл OUTPUT.TXT выведите целое число – значение второго максимума.

Console.Clear();
Console.Write("Введите 1 чило: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 чило: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3 чило: ");
int c = int.Parse(Console.ReadLine()!);
Console.Write("Введите 4 чило: ");
int d = int.Parse(Console.ReadLine()!);
Console.Write("Введите 5 чило: ");
int e = int.Parse(Console.ReadLine()!);
Console.Write("Введите 6 чило: ");
int f = int.Parse(Console.ReadLine()!);
int g = 0;
Console.WriteLine ($"{a} {b} {c} {d} {e} {f} {g}");
int max = a;
if(max < b) max = b;
if(max < c) max = c;
if(max < d) max = d;
if(max < e) max = e;
if(max < f) max = f;
Console.WriteLine (max);
int max1 = 0;
if(max1 > max && max1 < a) max1 = a;
else if(max1 < max && max1 <b) max1 = b;
else if(max1 < max && max1 <c) max1 = c;
else if(max1 < max && max1 <d) max1 = d;
else if(max1 < max && max1 <e) max1 = e;
else if(max1 < max && max1 <f) max1 = f;
Console.Write($"Второе максимальное число {max1}");