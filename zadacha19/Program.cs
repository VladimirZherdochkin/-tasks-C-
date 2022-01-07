//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите х");
int x = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите y");
int y = Int32.Parse(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("Заданные числа находяся в 1 четверти");
}
if (x == 0 || y == 0) { Console.WriteLine("Вне четверти"); }
if (x > 0 && y < 0) { Console.WriteLine("Заданные числа находяся в 4 четверти");}
if (x < 0 && y < 0) { Console.WriteLine("Заданные числа находяся в 3 четверти");}
