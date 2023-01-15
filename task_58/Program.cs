//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int m = InputNumbers("введите количество строк для 1ой матрицы: ");
int n = InputNumbers("введите количество столбцов для 1ой матрицы и строк для 2ой: ");
int p = InputNumbers("введите количество столбцов для 2ой матрицы: ");
int range = InputNumbers("введите диапозон случайных чисел от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\n1ая матрица:");
PrintArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
CreateArray(secondMartrix);
Console.WriteLine($"\n2ая матрица:");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[m, p];

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"\nпроизведение двух матриц:");
PrintArray(resultMatrix);
