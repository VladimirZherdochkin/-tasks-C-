//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.WriteLine("Введите x");
bool x = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Введите y");
bool y = Convert.ToBoolean(Console.ReadLine());
bool result = (!(x || y)) == (!x && !y);
Console.WriteLine(result);
