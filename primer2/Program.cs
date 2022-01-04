//По двум заданным числам проверять является
// ли первое квадратом второго
Console.WriteLine("Введите первое число");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numbersB = Convert.ToInt32(Console.ReadLine());
if (numbersA == Math.Pow(numbersB, 2) || numbersB == Math.Pow(numbersA, 2))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}