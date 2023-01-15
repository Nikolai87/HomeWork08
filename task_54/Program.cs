// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int ReadInt()
{
    return int.Parse(Console.ReadLine());
}


int[,] GetArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    Random rnd = new Random();

    for (int i = 0; i < firstLength; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = rnd.Next(100);
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

void ChangeRow(int[,] array, int row)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[row, i] > array[row, j])
            {
                int temp = array[row, i];
                array[row, i] = array[row, j];
                array[row, j] = temp;
            }
        }
    }

}
void ChangeEveryRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        ChangeRow(array, i);
}

int[,] array = GetArray(4, 4);

PrintArray(array);
ChangeEveryRow(array);
PrintArray(array);


