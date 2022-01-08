//Показать таблицу квадратов чисел от 1 до N
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i * i <= N; i++)
{
    Console.Write($"[{i}]={i * i},");
    if (i % 5 == 0)
    {
        System.Console.WriteLine();
    }
}