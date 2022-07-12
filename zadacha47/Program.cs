// Написать программу копирования массива

int[] CreateArray(int sizeArray, int min, int max)
{
    int[] arrayToReturn = new int[sizeArray];
    Random rnd = new Random();
    for (int i = 0; i < sizeArray; i++)
    {
        arrayToReturn[i] = rnd.Next(min, max);
    }
    return arrayToReturn;
}

void ShowArray(int[] arrayToShow, string nameOfArray)
{
    System.Console.WriteLine($"________{nameOfArray}________");
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write($"{arrayToShow[i]} \t");
    }
    Console.WriteLine();
}

int[] CopyArray(int[] arrayToCopy)
{
    int[] copyArray = new int[arrayToCopy.Length];
    for (int i = 0; i < arrayToCopy.Length; i++)
    {
        copyArray[i] = arrayToCopy[i];
    }
    return copyArray;
}

int[] resultArray = CreateArray(10, 1, 10);
ShowArray(resultArray, "Первоначальный массив");
int[] resultCopyArray = CopyArray(resultArray);
resultArray[4] = 20;
ShowArray(resultArray, "Измененный массив");
ShowArray(resultCopyArray, "Скопированный массив");