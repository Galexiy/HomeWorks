// ДЗ-7

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double[,] GreatRandom2dArray(int rows, int colums)  
{
    double [,] array = new double[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().NextDouble();
           
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round((array[i, j]),1) + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number of columns");
int n = Convert.ToInt32(Console.ReadLine());


double [,] myArray = GreatRandom2dArray(m, n);
Show2dArray(myArray);
*/





//____________________________________________________________________________

/*
int[,] GreatRandom2dArray(int rows, int colums, int minValue, int maxValue)  
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк для создания массива ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов для создания массива ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите min значение числа в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите max значение числа в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = GreatRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/

//_______________________________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

/*
Console.WriteLine("Введите проверяемое число на позиции в строке  ");
int mm = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите проверяемое число на позиции в столбце   ");
int nn = Convert.ToInt32(Console.ReadLine());
void ShowElement(int[,] array, int nn, int mm)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == mm && j == nn)
                Console.WriteLine($"Число на этой позиции найдено" + " " + array[i, j]);
    }

}
ShowElement(myArray, mm, nn);

void CheckIndex(int[,] array, int nn, int mm)
{
    if (mm > array.GetLength(0) || nn > array.GetLength(1))
        Console.WriteLine("значение не найдено");
}
CheckIndex(myArray, mm, nn);
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
void SumColumns (int [,] array)
{   double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];     
        }
        double sSum = sum / array.GetLength(0);
        Console.Write($"{Math.Round(sSum,1)} ");
    }
    Console.ReadLine();    
}
SumColumns(myArray);
*/

