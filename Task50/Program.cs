// =====================================================================================================================
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
//этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
void CreateArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(0, 10);
    }
}

void PrintArray(int[,] arr)
{
    //Console.Write("[");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    //Console.WriteLine("]");
}

Console.Clear();
Console.WriteLine("Есть массив 5х8:");
int[,] array = new int[5, 8];
CreateArray(array);
PrintArray(array);
Console.Write("Введите № строки массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите № столбца массива: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > array.GetLength(0) || n > array.GetLength(1) || m <= 0 || n <= 0)
{
    Console.WriteLine("\nВыбранный элемент массива отсутствует");
    return;
}
Console.WriteLine("\nВыбранный элемент массива: " + array[m - 1, n - 1]);