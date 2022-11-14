// =====================================================================================================================
// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void CreateArray(double[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //arr[i, j] = Math.Round(rnd.NextDouble() * 10, 2);
            arr[i, j] = rnd.Next(-9, 10);
            if (rnd.Next(0, 2) == 1)
                arr[i, j] *= (-1);
        }
    }
}

void PrintArray(double[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " \t");
        Console.WriteLine();
    }
}

void SortMatrix(double[,] arr)
{
    double temp = 0;
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
string[] num = Console.ReadLine().Split(' '); // ввод двух чисел в одну строку
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
double[,] matr = new double[m, n];
CreateArray(matr);
Console.Write("Начальный массив: ");
PrintArray(matr);
SortMatrix(matr);
Console.Write("Результат: ");
PrintArray(matr);

