// =====================================================================================================================
// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void CreateArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(-9, 10);
    }
}

void PrintArray(int[,] arr)
{
    //Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " \t");
        Console.WriteLine();
    }
}

void SortMatrix(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = arr.GetLength(1) - 1; j > 0; j--)
        {
            for (int k = 0; k < j; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
}

Console.Clear();

Console.Write("Введите размерность массива через пробел: ");

string[] num = Console.ReadLine().Split(" "); // ввод двух чисел в одну строку
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matr = new int[m, n];
CreateArray(matr);

Console.WriteLine();
Console.WriteLine("Начальный массив:");
PrintArray(matr);

SortMatrix(matr);
Console.WriteLine();
Console.WriteLine("Результирующий массив:");
PrintArray(matr);

