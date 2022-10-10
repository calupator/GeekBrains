//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if ((0 < day) && (day < 8))
    if ((day == 6) || (day == 7))
        Console.Write("Опа, и выходной ;-)");
    else
        Console.Write("Это не выходной :-)");
else
    Console.Write("Вы ввели неверный номер дня недели!!!");