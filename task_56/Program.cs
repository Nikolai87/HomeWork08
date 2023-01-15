// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//int ReadInt()
//{   
//    return int.Parse(Console.ReadLine());
//}

int[,] GetArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    Random rnd = new Random();

    for (int i = 0; i < firstLength; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

void CalculateRows(int[,] array)
{
    PrintArray(array);
    int minRow = 0;
    int min = SumRow(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = SumRow(array, i);
        if (sum < min)
        {
            min = sum;
            minRow = i;
        }
        if (i == array.GetLength(0) - 1 && i == array.GetLength(1) - 1) 
    Console.WriteLine($"строка с наименьшей суммой элементов - {minRow + 1}");
    }
}
int SumRow(int[,] array, int i)
{
    int temp = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        temp = temp + array[i, j];
    }
    return temp;
}

int[,] array = GetArray(5, 5);
Console.WriteLine();
CalculateRows(array);



