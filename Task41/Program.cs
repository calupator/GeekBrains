// =====================================================================================================================
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> (3)4!!!

static void CreateArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
Console.WriteLine("Введите последовательно элементы массива:");
CreateArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Кол-во положительных чисел: " + count);
