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

Clear();
Write("Введите число а: ");
int a = int.Parse(ReadLine());
int summa = GetSumNumbers(a);
WriteLine($"Сумма = {summa}");

int GetSumNumbers(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}