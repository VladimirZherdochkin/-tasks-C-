//Найти максимальное из трех чисел
int a, b, c;
Console.WriteLine("Введите первое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a) max = b;
if (c > max) max = c;
Console.WriteLine(max);