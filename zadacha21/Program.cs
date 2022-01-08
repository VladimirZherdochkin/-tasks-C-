//Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int reverse = 0;
int remainder = 0;
int count = 0;
    while (number > reverse)
    {
        remainder = number % 10;
        reverse = reverse * 10 + remainder;
        number = number / 10;
        count++;
    }
    Console.WriteLine(count);
    if (reverse == number)
    {
        Console.WriteLine("Your number is a palindrome");
    }
    else
    {
        number = number * 10 + remainder;
        if (reverse == number)
            Console.WriteLine("your number is a palindrome");
        else
            Console.WriteLine("your number is not a palindrome");
    }
    Console.ReadLine();
