﻿//Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (99 < a && a < 1000)
{
    int result = (a % 100)/10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ввели число не соответсвующее условию");
}