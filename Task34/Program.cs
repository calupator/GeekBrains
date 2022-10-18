// =====================================================================================================================
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая
//покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void CreateArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(-999, 1000);
}

int CCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        count += ((arr[i] % 2) == 0) ? 1 : 0;
    }
    return count;
}

Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
CreateArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(CCount(array));