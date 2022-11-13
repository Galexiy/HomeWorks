// ДЗ - 5

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] GreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

int[] myArray = GreateRandomArray(4, 100, 1000);
ShowArray(myArray);


int[] newArray(int[] myArray)
{
    int count = 0;
    for(int i = 0; i < myArray.Length; i++)
    {   
        
        if(myArray[i] % 2 == 0)
        
        count++;
     
    }
    Console.WriteLine($"Колличество четных чисел равно {count} ");  
    return myArray;
     
}

int[] nArray = newArray(myArray);
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


/*
int[] GreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

int[] myArray = GreateRandomArray(4, -10, 100);
ShowArray(myArray);


int[] newArray(int[] myArray)
{
    int sum = 0;
    for(int i = 0; i < myArray.Length; i+=2)
    {
        sum = sum + myArray[i];
   
    }  
    Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях будет равна {sum} "); 
    return myArray;
    
}

int[] nArray = newArray(myArray);
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


/*
double[] myArray = {3, -7, -22.33, 2, 78};
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    
         Console.Write(array[i] + "  ");
    Console.WriteLine();
}
ShowArray(myArray);



double[] newArray(double[] myArray)
{
    double max = 0;
    for(int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i] > max)
            max = myArray[i];

   
    }  
    Console.WriteLine($"Найдено максимальное число {max} "); 
    double min = 0;
    for(int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i] < min)
            min = myArray[i];

   
    }  
    Console.WriteLine($"Найдено минимальное число {min} "); 

    double rez = max - min;
    Console.WriteLine($"Разница между максимальными и минимальными элементами массива будет равна {rez} "); 
    return myArray;
    
}

double[] nArray = newArray(myArray);
*/