// =====================================================================================================================
//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] LinesIntersects(double a, double c, double b, double d)
{
    double[] retVal = new double[2];
    retVal[0] = (d - c) / (a - b);
    retVal[1] = ((a * d) - (b * c)) / (a - b);
    return retVal;
}

Console.Clear();

double b1 = 2, k1 = 5;
double b2 = 4, k2 = 9;
double[] point = LinesIntersects(k1, b1, k2, b2);
Console.Write($"Точка пересечения двух прямых: ({string.Join(", ", point)})");