// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число 1  ");
int x = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine(" Введите число 2  ");
int y = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine(" Введите число 3  ");
int z = Convert.ToInt32 (Console.ReadLine());

int max = x;

if (x> max) max = x;
if (y> max) max = y;
if (z> max) max = z;

Console.Write("max = ");
Console.WriteLine(max);