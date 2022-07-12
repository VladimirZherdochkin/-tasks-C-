//Найти сумму чисел от 1 до А
System.Console.WriteLine("Введите число N");
long N = Convert.ToInt64(Console.ReadLine());
DateTime dt = DateTime.Now;// текущее время
long Sum = 0;
//for (long i = 1; i <= N; i++)
//{
//    Sum = Sum + i;
//}
Sum = N * (N + 1) / 2;
Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);
Console.WriteLine(Sum);