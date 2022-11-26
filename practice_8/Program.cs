
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



// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
void ArrangeNumbersString(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    
        for (int j = 0; j < array.GetLength(1); j++)
        
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            
                if (array[i, k] > array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
}

ArrangeNumbersString(myArray);
Show2dArray(myArray);
*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int StringSmallestElement (int [,] array)
{   
    int sum = 0;
    int k = 0;
    int[] rowSum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[i,j]; 
            rowSum[i] = sum;      
        }
        int min = rowSum[0];
        if (rowSum[i] < min)
        {
            rowSum[i] = min;
            k = i;
        }
    }
    return (k+1);
}

int value = StringSmallestElement(myArray);
Console.WriteLine($"В {value} стоке наименьшая сумма элементов.");
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool TestMatrix(int[,] firstMartrix, int[,] secomdMartrix)
{
    if (firstMartrix.GetLength(1) == secomdMartrix.GetLength(0))
    {
        return true;
    } 
    else return false;
}

void MultiplicationMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

}


Console.WriteLine("Введите количество строк для создания 1-й матрицы ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов для создания 1-й матрицы ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите min значение числа в 1-й матрицы ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите max значение числа в 1-й матрицы ");
int max = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите количество строк для создания 2-й матрицы ");
int m2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов для создания 2-й матрицы ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите min значение числа в 2-й матрицы ");
int min2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите max значение числа в 2-й матрицы ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = GreatRandom2dArray(m, n, min, max);
Show2dArray(firstMartrix);

int[,] secomdMartrix = GreatRandom2dArray(m2, n2, min2, max2);
Show2dArray(secomdMartrix);

int[,] resultMatrix = new int[m, n];
MultiplicationMatrix(firstMartrix, secomdMartrix, resultMatrix);
Show2dArray(resultMatrix);

bool res = TestMatrix(secomdMartrix, resultMatrix);
Console.WriteLine(res);
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int[,,] GreatRandom2dArray(int rows, int colums, int dep, int minValue, int maxValue) 
{
    int[,,] array = new int[rows, colums, dep];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            for (int k = 0; k < colums; k++)
            array[i, j, k] = new Random().Next(minValue, maxValue + 1);
    return array;
}



void Show2dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            for (int k = 0; k < array.GetLength(2); k++)

                Console.Write(array[i, j, k] + "  ");

        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine("Введите количество строк для создания трехмерного массива ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов для создания трехмерного массива ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество слоев для создания трехмерного массива ");
int k = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Введите min значение числа в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите max значение числа в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] array3d = GreatRandom2dArray(m, n, k, min, max);
Show2dArray(array3d);
*/
