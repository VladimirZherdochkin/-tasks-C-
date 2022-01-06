// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (99 < a && a < 1000)
{
    int result = a % 10;
    Console.WriteLine(result);
}