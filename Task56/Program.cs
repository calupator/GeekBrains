// =====================================================================================================================
// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);
    }
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
    }
}

int CompareRow(int[,] matrix)
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
            min = SumRow[i];
            NumberRow = i + 1;
    }
    return min;
}

Console.Clear();
Console.Write("Введите размерность прямоугольного массива (n x n): n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
Console.WriteLine("Массив: ");
InputMatrix(matrix);
Print(matrix);
Console.WriteLine ($"Минимальное значение суммы элементов строки: " + CompareRow(matrix));
