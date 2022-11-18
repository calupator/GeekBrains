// =====================================================================================================================
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void SpiralMatrix(int[,] matrix)
{
    int temp = 1, i = 0, j = 0;
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= (j + 1) && (i + j) < matrix.GetLength(1) - 1)
            j++;
        else if ((i < j) && (i + j) >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && (i + j) > matrix.GetLength(0) - 1)
            j--;
        else
            i--;
    }
    PrintMatrix(matrix);
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
                Console.Write("0" + arr[i, j] + " \t");
            else
                Console.Write(arr[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите размерность матрицы (n х n): n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
Console.WriteLine("Заполненая матрица:");
SpiralMatrix(matrix);