// =====================================================================================================================
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
void CreateArray(double[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(rnd.NextDouble() * 10, 2);
            if(rnd.Next(0, 2) == 1) // для случайного изменения знака числа
                arr[i, j] *= (-1);
        }
    }
}

void PrintArray(double[,] arr)
{
    // Console.Write("[");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] /*+ ", "*/);
        Console.WriteLine();
    }
    // Console.WriteLine("]");
}

Console.Clear();

Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
CreateArray(array);
PrintArray(array);
