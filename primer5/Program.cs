//Написать программу вычисления значения функции y = f(a)=(1+1/a)^a
Console.WriteLine("Введите переменную а=");
double a = Convert.ToDouble(Console.ReadLine());
double y = 0;
if (a == 0)
{
    Console.WriteLine("Число не корректно!");
}
else
{
    y = Math.Pow((1 + 1 / a),a);
}
Console.WriteLine($"{y}");