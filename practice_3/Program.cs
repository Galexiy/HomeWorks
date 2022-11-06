// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


/*
void Palindrome(int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num % 100 / 10;
    int num5 = num % 10;

    if (num1 == num5 && num2 == num4)
    {
       Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - не палиндром");
    }

}
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Palindrome(n);
*/


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


/*
double Theorem(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double x = Math.Pow(x2 - x1,2);
    double y = Math.Pow(y2 - y1,2);
    double z = Math.Pow(z2 - z1,2);

    double hypotenus = Math.Sqrt(x + y + z);
    hypotenus = Math.Round(hypotenus,2);
    return hypotenus;
}
Console.WriteLine("Введите координату точки А - Х1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки А - Y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки А - Z1");
int z1 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Введите координату точки B - Х2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B - Y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B - Z2");
int z2 = Convert.ToInt32(Console.ReadLine());



double rez = Theorem(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками будет {rez}");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



/*
void Squaer(int n)
{
    int num = 1;
    while (num <= n)
    {
        Console.Write(Math.Pow(num,3) + " ");
        num++;
    }

}

Console.WriteLine("Введите число   ");
int n = Convert.ToInt32(Console.ReadLine());
Squaer(n);
*/


