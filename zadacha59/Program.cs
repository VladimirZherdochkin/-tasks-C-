//59) В прямоугольной матрице найти строку с наименьшей суммой элементов

void FillArray(int[,] array, int columnLength, int lineLength)
{
    for (int i = 0; i < columnLength; i++)
    {
        for (int j = 0; j < lineLength; j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}

void SumArray(int[,] array, int columnLength, int lineLength)
{
    int minIndex = 0;
    int minSumArr = 0;
    for (int k = 0; k < lineLength; k++)
    {
        minSumArr += array[0,k];
    }
    System.Console.WriteLine($"Sum line 0 is {minSumArr}");
    for (int i = 1; i < columnLength; i++)
    {
        int sum = 0;
        for (int j = 0; j < lineLength; j++)
        {
            sum += array[i, j];
        }
        System.Console.WriteLine($"Sum line {i} is {sum}");
        if (minSumArr > sum)
        {
            minSumArr = sum;
            minIndex = i;
        }
    }
    System.Console.WriteLine($"{minIndex} line with the smallest sum of elements");
}


System.Console.Write("Enter");
