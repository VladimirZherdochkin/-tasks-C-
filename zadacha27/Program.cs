//Определить количество цифр в числе
Console.Write("Введите число: ");
int n = Console.ReadLine();
int a = 0;
int kolvo=0;
while (a <= n.Length)
{
    kolvo = a++;
}
Console.WriteLine("Количество цифр {0}", kolvo);
Console.ReadKey();