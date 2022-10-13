// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите три числа через enter");

int count = 0;
int a = int.Parse(Console.ReadLine()!);
int max = a;
int min = a;
while(count<2) //можно задать любое количество чисел для сравнения
{int b = int.Parse(Console.ReadLine()!);
 if (b>max) max = b;
 if (b<min) min = b;
 count++;
 }

Console.WriteLine("max="+max);
Console.WriteLine("min="+min);

//наверное можно было сделать легче, но что ниего в голову не пришло.
