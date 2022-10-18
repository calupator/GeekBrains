// =====================================================================================================================
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void CreateArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(-999, 1000);
}

int Sum(int[] arr)
{
    int ret = 0;
    for (int i = 1; i < arr.Length; i += 2)
        ret += arr[i];
    return ret;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
CreateArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Сумма элементов на нечетных позициях: " + Sum(array));
