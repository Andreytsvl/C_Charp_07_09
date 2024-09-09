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
// Clear();

// WriteLine($"[{String.Join(",", GetArray(8))}]");
// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(20);
//     }
//     return result;
// }

// task 31
// Clear();
// int[] array = GetArray(12, -9, 9);
// WriteLine(String.Join("," , array));
// int positiveSum = 0;
// int negativeSum = 0;
// foreach (int item in array)
// {
//     if (item > 0)
//     {
//         positiveSum += item;
//     }
//     else
//     {
//         negativeSum += item;
//     }
// }
// WriteLine ($"Сумма положительных элементов равно {positiveSum}");
// WriteLine ($"Сумма отрицательных элементов равно {negativeSum}");


// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }

// task 32
// Clear();
// int[] array = GetArray(8, -10, 10);
// WriteLine(String.Join(" " , array));
// InverseArrey(array);
// WriteLine(String.Join(" " , array));

// первый способ (мой)
// for (int i = 0; i < array.Length; i++)
// {
//    array[i]=-1*array[i]; 
// }
// WriteLine(String.Join("," , array));

// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }

// // второй способ через метод
// void InverseArrey(int[] inArrey)
// {
//     for (int i = 0; i < inArrey.Length; i++)
//     {
//         inArrey[i]*=-1;
//     }
// }

// task 33
// Clear();
// WriteLine("Введите через пробел массив: ");
// int [] array = GetArrayFromString(ReadLine());
// Write("Введите элемент: ");
// int element = int.Parse(ReadLine());
// if(FindeElement(array,element))
// {
//    WriteLine("да"); 
// }
// else
// {
//     WriteLine("нет");    
// }


// int[] GetArrayFromString(string stringArray)
// {
//     string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     int[] result = new int[numS.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i]= int.Parse(numS[i]);
//     }
//     return result;
// }

// bool FindeElement(int[] inArray, int el)
// {
//     foreach(int item in inArray)
//     {
//         if(item == el) return true;
//     }
//     return false;
// }

// task 35
// Clear();
// int[] array = GetArray(10, 0, 1000);
// WriteLine(String.Join(",", array));
// Write("Введите число а - начало диапазона: ");
// int a = int.Parse(ReadLine());
// Write("Введите число b - начало диапазона: ");
// int b = int.Parse(ReadLine());
// int count = CountArrey(array, a, b);
// WriteLine($"{ count}");




// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }

// int CountArrey(int[] inArray, int a, int b)
// {
//     int count = 0;
//     foreach (int item in inArray)
//     {

//         if (item >= a && item <= b)
//         {
//             count = count + 1;
//         }

//     }
//     return count;
// }

// task 37
Clear();
int[] array = GetArray(4, 0, 10);
WriteLine(String.Join(",", array));
int[] res2 = GetArrayRes(array);

WriteLine(String.Join(" ", res2));


int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int[] GetArrayRes(int[] inArray)
{

    int k = inArray.Length / 2;

    if (inArray.Length % 2 == 1) k++;
    int[] result1 = new int[k];

    for (int j = 0; j < inArray.Length / 2; j++)
    {
        result1[j] = inArray[j] * inArray[inArray.Length - j - 1];

    }
    if (inArray.Length % 2 == 1) result1[k - 1] = inArray[inArray.Length / 2];

    return result1;
}