//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
if (a<1) Console.WriteLine("Для корректной работы число должно быть больше 1");
int count = 1;
int b = 0;
while (count<=a)
     {
          b = (count%2);
    if (b == 0) Console.Write(count+" ");
   
     
    count++;
     }