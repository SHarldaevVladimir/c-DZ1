﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int b = (a%2);
if (b == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");


