// ДЗ - 4

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int Degree(int a, int b)
{
    int step = a;

    for(int i = 1; i < b; i++)
    {
        step = step * a;

    }
    return step;
    
}

Console.WriteLine("Введите число A  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В  ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число А в натуральной степени В будет равно {Degree(a,b)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int Find(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;

}

Console.WriteLine("Введите число:  ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {Find(a)}");
*/


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] arr = {1, 2, 5, 7, 19};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

PrintArray(arr);
*/
