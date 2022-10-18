Console.Clear();
Console.Write("Введите ко-во кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] result = new int[n];

for(int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i < array.Length - 1; i++)
    result[i - 1] = array[i - 1] + array[i] + array[i + 1];

result[result.Length - 2] = array[0] + array[array.Length - 1] + array[array.Length - 2];
result[result.Length - 1] = array[0] + array[1] + array[array.Length - 1];

Console.WriteLine($"[{string.Join(", ", result)}]");
int maxValue = result[0];
for(int i = 1; i < result.Length; i++)
    if(maxValue < result[i])
        maxValue = result[i];
Console.WriteLine(maxValue);