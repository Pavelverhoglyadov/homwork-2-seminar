﻿Console.WriteLine("введите трехзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 >= 100 && num1 <= 999);
   

else
{
    Console.WriteLine("третьей цифры числа нет");
}
int x1 = num1 / 10;
int x2 = x1 % 10;


Console.WriteLine($"вторая цифра этого числа {x2}");