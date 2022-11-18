// =====================================================================================================================
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void CreateArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
        //Console.WriteLine();
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

int[,] MulMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] ResultMAtrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(0)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(1); ++k)
                ResultMAtrix[i, k] += firstMatrix[i, j] * secondMatrix[j, k];
        }
    }
    return ResultMAtrix;
}

Console.Clear();

Console.Write("Введите размерность матрицы (n x n): n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[n, n];
CreateArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица А:");
PrintArray(matrixA);

int[,] matrixB = new int[n, n];
CreateArray(matrixB);
Console.WriteLine();
Console.WriteLine("Матрица В:");
PrintArray(matrixB);

int[,] matrixC = MulMatrix(matrixA, matrixB);
Console.WriteLine();
Console.WriteLine("Произведение C:");
PrintArray(matrixC);