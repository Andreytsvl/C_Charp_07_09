// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// double CalculateFormula(int a, int b, int c, int d)
// {
//     double num = a * b; // чтоб результат деления был дробным
//     int denum = c + d;
//     double result = num / denum;
//     return result;
// }

// double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);

// task 24
using System;
using static System.Console;

// Clear();
// Write("Введите число а: ");
// int a = int.Parse(ReadLine());
// int summa = GetSumNumbers(a);
// WriteLine($"Сумма = {summa}");

// int GetSumNumbers(int a)
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// task 26
// Clear();
// Write("Введите число а: ");
// WriteLine($"Количество цифр в числе = {GetLenNumbers(int.Parse(ReadLine()))}");

// int GetLenNumbers(int a)
// {
//     int len = 1;
//     while (a > 10)
//     {

//         //a = Math.Abs(a); // не работает
//         a = (a / 10);
//         len = len + 1;
//     }
//     return len;
// }

// task 28
// Clear();
// Write("Введите число а: ");
// WriteLine($"Факториал числа = {GetFactorial(int.Parse(ReadLine()))}");

// int GetFactorial(int a)
// {
//     int factor = 1;
//     for (int i = 2; i <= a; i++)
//     {
//         factor *= i;
//     }
//     return factor;
// }

// task 30
// Clear();

// int[] arr = new int[8];
// int i = 0;
// while (i < 8)
// {
//     arr[i] = new Random().Next(0, 2);
//     Write($"{arr[i]} ");
//     i++;
// }

//
// WriteLine($"[{String.Join(",",GetBinaryArray(8))}]");
// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(0, 2);
//     }
//     return result;
// }

// task 25_DZ
// Clear();
// Write("Введите число a: ");
// int a = int.Parse(ReadLine());
// Write("Введите число b: ");
// int b = int.Parse(ReadLine());
// int step = Pow(a, b);
// WriteLine($"Число а в степени в = {step}");

// int Pow(int x, int y)
// {
//     if (y == 0)
//     {
//         return 1;
//     }
//     int res = a;
//     for (int i = 2; i <= y; i++)
//     {
//         res *= x;
//     }
//     return res;
// }

// task 27_DZ
// Clear();
// Write("Введите число a: ");
// WriteLine($"Сумма цифр в числе = {GetSumNumbers(int.Parse(ReadLine()))}");

// int GetSumNumbers(int x)
// {
//     int sum = 0;
//     while (x > 0)
//     {
//         sum += x % 10;
//         x /= 10;
//     }
//     return sum;
// }

// task 29_DZ
Clear();

WriteLine($"[{String.Join(",",GetArray(8))}]");
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(20);
    }
    return result;
}