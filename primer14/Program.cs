//Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if(99<a)
{
    int result = a % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Последней цифры нет");
}
