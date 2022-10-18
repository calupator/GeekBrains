// =====================================================================================================================
//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
static void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(1, 10);
}
static void Mul(int[] arr)
{
    for (int i = 0; i < arr.Length / 2 + arr.Length % 2; i++)
        Console.Write($"{arr[i] * arr[arr.Length - i -1]} ");
}

Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
CreateArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Mul(array);