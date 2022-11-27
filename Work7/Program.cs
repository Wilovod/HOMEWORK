// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Ввеидите число от 1 до 7 ");
int Day = Convert.ToInt32(Console.ReadLine());

if(Day < 1)

{
    Console.WriteLine("Нет такого дня");
}
if(Day > 7)
{
   Console.WriteLine("Нет такого дня");
}

if(Day == 1)
{
    Console.WriteLine("Понедельник, рабочий день");
}
if(Day == 2)
{
    Console.WriteLine("Вторник, рабочий день");
}
if(Day == 3)
{
    Console.WriteLine("Среда, рабочий день");
}
if(Day== 4)
{
    Console.WriteLine("Четверг, рабочий день");
}
if(Day == 5)
{
    Console.WriteLine("Пятница, рабочий день");
}
if(Day == 6)
{
   Console.WriteLine("Суббота, выходной");
}
if(Day == 7)
{
   Console.WriteLine("Воскресенье, выходной");
}

