//Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (100 > a)
{
    Console.WriteLine("Нет третьей цифры!");
}
else
{
    string y = Convert.ToString(a);
    Console.WriteLine(y[2]);
}
