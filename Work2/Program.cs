// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Введите NumberOne ");
int NumberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите NumberTwo ");
int NumberTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите NumberThree ");
int NumberThree = Convert.ToInt32(Console.ReadLine());


int max = NumberOne;


if (NumberTwo > max) max = NumberTwo;
if (NumberThree > max) max = NumberThree;


Console.Write("max = ");
Console.WriteLine(max);


