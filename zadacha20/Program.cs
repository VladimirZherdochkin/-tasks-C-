//Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти");
int chetvert = Convert.ToInt32(Console.ReadLine());
if (chetvert == 1)
{
    Console.WriteLine("(x > 0) && (y > 0)");
}
if (chetvert == 2)
{
    Console.WriteLine("(x < 0) && (y > 0)");
}
if (chetvert == 3)
{
    Console.WriteLine("(x < 0) && (y < 0)");
}
if (chetvert == 4)
{
    Console.WriteLine("(x > 0) && (y < 0)");
}