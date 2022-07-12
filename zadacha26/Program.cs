//Возведите число А в натуральную степень B используя цикл
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень этого числа");
// int b = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(Math.Pow(a,b));
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= b; j++)
    {
        Console.WriteLine(i*j);
    }
}

 