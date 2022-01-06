//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int result = a % b;
if (result != 0)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Кратно");
}