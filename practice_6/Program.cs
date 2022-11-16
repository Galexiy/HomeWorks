//ДЗ 6

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int[] array = {0, 7, 8, -2, -2};
void CountNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0)
            count++;

    Console.WriteLine($"Количество положительный чисел будет равно {count}");

}
CountNum(array);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// вдруг линии папаллельные или совпадают?

/*
void LineIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Пересечение в точке: ({x};{y})");

    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("прямые совпадают");

    if (k1==k2)
        Console.WriteLine("прямые параллельны");

}

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

LineIntersection(b1, k1, b2, k2);
*/