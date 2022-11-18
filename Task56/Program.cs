// =====================================================================================================================
// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void CreateArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-10, 11);
            // Console.Write($"{matrix[i, j]} \t");
        }
        //Console.WriteLine();
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " \t");
        Console.WriteLine();
    }
}

int CompareRow(int[,] matrix, ref int index)
{
    int[] SumRow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow[i] += matrix[i, j];
        }
    }
    int min = SumRow[0];
    int NumberRow = 0;
    for (int i = 0; i < SumRow.Length; i++)
    {
        if (SumRow[i] < min)
        {
            min = SumRow[i];
            index = NumberRow = i + 1;
        }
    }
    return min;
}

Console.Clear();

Console.Write("Введите размерность прямоугольного массива (n x n): n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];

Console.WriteLine("Массив:");
CreateArray(matrix);
PrintArray(matrix);

int minIndex = 0;
int minSum = CompareRow(matrix, ref minIndex);

Console.WriteLine();
Console.WriteLine("Минимальное значение суммы элементов в строке № {0}: {1}", minIndex, minSum);
