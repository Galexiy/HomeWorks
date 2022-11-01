// ДЗ:   Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNum (int num)
{
    int ed = num % 100 / 10;
    
    num = ed; 

    return num;
}

Console.Write("Введите трехзначное число   ");
int a = Convert.ToInt32(Console.ReadLine());
int result = CutNum(a);

Console.WriteLine($"Второй цифрой числа {a} является {result}");
*/

// ДЗ: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
int CutNum(int number)

{   int rez = -1;
    if (number >= 100)
    {
        while(number > 1000)
        {
            number = number / 10;
        }
    
        rez = number % 10;            

    }
    return rez;

}

Console.Write("Введите число   ");
int a = Convert.ToInt32(Console.ReadLine());
int result = CutNum(a);

Console.WriteLine($" Заданное число {a} имеет третью цифру {result}");
*/

// ДЗ Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
bool Calendar (int number)
{
    if(number == 6 || number == 7)
    {
        return true;
    }
    else
    {
        return false;
    }

}


Console.Write("Введите число   ");
int a = Convert.ToInt32(Console.ReadLine());

bool result = Calendar(a);
Console.WriteLine($" Число {a} выходной день? {result}");
*/