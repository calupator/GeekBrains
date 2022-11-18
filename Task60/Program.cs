// =====================================================================================================================
//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

void CreateMatrix3D(int[,,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = CheckNumbers(arr, rnd.Next(10, 100));
            }
        }
    }

}

void PrintMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
                Console.Write(arr[i, j, k] + "(" + j.ToString() + "," + k.ToString() + "," + i.ToString() + ")" + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int CheckNumbers(int [,,] matrix, int number)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j, k] == number)
                {
                    return CheckNumbers(matrix, rnd.Next(10, 100));
                }
            }
        }
    }
    return number;
}

Console.Clear();

//Console.Write("Введите размерность матрицы (n x n х n): n = ");

//int n = Convert.ToInt32(Console.ReadLine());
int n = 2;

Console.WriteLine();
int[,,] matrix3D = new int[n, n, n];
CreateMatrix3D(matrix3D);
Console.WriteLine("3D Матрица:");
PrintMatrix(matrix3D);