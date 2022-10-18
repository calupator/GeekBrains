// =====================================================================================================================
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void CreateArray(double[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.NextDouble() * 100;
}

double FindMin(double[] arr)
{
    double ret = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (ret > arr[i])
            ret = arr[i];
    }
    return ret;
}

double FindMax(double[] arr)
{
    double ret = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (ret < arr[i])
            ret = arr[i];
    }
    return ret;
}

Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
CreateArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Разница: " + Math.Round((FindMax(array) - FindMin(array)), 1));