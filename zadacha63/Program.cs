// Сформировать трехмерный массив c не повторяющимися двузначными числами показать 
// его построчно на экран выводя индексы соответствующего элемента

int[,,] CreateArray(int row, int col, int z)
{
    //int number = 10;
    int[,,] array = new int[row, col, z];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = GetNextRandomUnicNumber();
            }
        }
    }
    return array;
}
int[] selectedNumbers = new int[89];
int GetNextRandomUnicNumber()
{
    int number = new Random().Next(10, 100);
    for (int i = 0; i < selectedNumbers.Length; i++)
    {
        if (selectedNumbers[i] == number)
        {
            return GetNextRandomUnicNumber();
        }
        else if (selectedNumbers[i] == 0)
        {
            selectedNumbers[i] = number;
            break;
        }
    }
    return number;
}

void Show3DArray(int[,,] arrayToShow)
{
    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToShow.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] = {arrayToShow[i, j, k]}\t");
            }
            Console.WriteLine();
        }
    }
}


int[,,] array = CreateArray(2, 3, 2);
Show3DArray(array);
