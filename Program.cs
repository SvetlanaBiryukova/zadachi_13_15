﻿//ДОМАШНЕЕ ЗАДАНИЕ

// Задача2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int a = 5;
int b = 6;
if (a > b )
{
    Console.WriteLine("min:" + b);
    Console.WriteLine("max:" + a);
}
else
{
    Console.WriteLine("min:" + a);
    Console.WriteLine("max:" + b);
}
*/
// Задача4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
int a = 5;
int b = 6;
int c = 12;
int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
    Console.WriteLine("максимальное значение:" + c);
*/

// Задача6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
int a = 8;
if (a % 2 == 0)
{
    Console.WriteLine( a + " четное");
}
else
{
    Console.WriteLine( a +  " нечетное");
}
*/

// Задача8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N = 13;
int b = 2;

while ( b < N )
{
    Console.WriteLine(b);
    b += 2;
}