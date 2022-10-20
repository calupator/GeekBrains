void CreateArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Convert.ToInt32(Console.ReadLine());
}

int[] Shift(int[] arr, int sh)
{
    sh %= arr.Length;
    int[] arr2 = new int[arr.Length];
    if (sh > 0)
    {
        for (int i = 0; i < sh; i++)
            arr2[i] = arr[arr.Length - sh + i];
        for (int i = 0; i < arr.Length - sh; i++)
            arr2[sh + i] = arr[i];
    }
    else
    {
        sh *= -1;
        for (int i = 0; i < sh; i++)
            arr2[arr.Length - sh + i] = arr[i];
        for (int i = 0; i < arr.Length - sh; i++)
            arr2[i] = arr[sh + i];
    }
    return arr2;
}

// =====================================================================================================================
//Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность
//(сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
//Входные данные
//Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai,
//а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).
Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Введите последовательно элементы массива:");
CreateArray(array, n);
Console.Write("Введите число для Супер Сдвига: ");
int shift = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", Shift(array, shift))}]");
