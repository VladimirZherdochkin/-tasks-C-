//Показать числа от -N до N
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = a*(-1); i <=a; i++)
{
    Console.WriteLine(i);
}