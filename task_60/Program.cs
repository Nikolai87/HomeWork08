// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int ReadInt(string argument)
{
    Console.Write($"введите {argument}: ");
    return int.Parse(Console.ReadLine());
}

void PrintThirdDimensionArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{i}-{j}-{k}: {array[i, j, k]} ");
            }
        }
    }
    Console.WriteLine();
}

int[,,] GetThreeDimensionUniqueArray(int length1, int length2, int length3)
{
    int[,,] array = new int[length1, length2, length3];
    Random rnd = new Random();

    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                int value = rnd.Next(10000);
                if (!HasValueInThreeDimensionmArray(array, value))
                    array[i, j, k] = value;
                else
                {
                    k--;
                }
            }
        }
    }

    return array;
}

bool HasValueInThreeDimensionmArray(int[,,] array, int value)
{
    foreach (int item in array)
    {
        if (item == value)
        {
            return true;
        }
    }

    return false;
}

int[,,] array = GetThreeDimensionUniqueArray(ReadInt("длина1"), ReadInt("длина2"), ReadInt("длина3"));
PrintThirdDimensionArray(array);
