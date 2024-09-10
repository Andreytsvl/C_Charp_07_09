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

// task 24  Напишите метод, который принимает на вход число
// и выдаёт сумму от 1 до А
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

// task 26 Напишите метод, кот. принимает на вход число
// и выдаёт к-во цифр в числе.
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

// task 28 Напишите метод, кот. принимает на вход число
// и выдаёт произведение чисел от 1 до Н.
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

// task 30 Напишите метод, выводящий массив из 8 эл-тов
// заполненый в случайном порядке 0 и 1.
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

// task 25_DZ Напишите цикл, который принимает на вход лисла А и В
//  и возводит А в степень В
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

// task 27_DZ Напишите метод, кот. принимает число
// и выдаёт сумму цифр в нём.
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

// task 29_DZ Напишите метод, кот. задаёт массив из 8 элементов
// и выводит на экран
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

// task 31 Задать массив из 12 эл-тов из случайных чсел от -9 до 9
// Найти сумму отр. и положит. эл-тов массива.
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

// task 32 Написать программу замены элементов массива
// положит. на отрицат. и наоборот.
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

// task 33 Задайте массив Напишите метод, кот. определяет 
// есть ли заданное число в массиве
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

// task 35 Задать одномерный массив из 123 случайных чисел
// найти к-во ел-тов, лежащих в интервале 10  99
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

// task 37 Найти произведение пар чисел в массиве (первый - последний)
// (второй - предпоследний). Результат вывести в новом массиве.
// Clear();
// int[] array = GetArray(4, 0, 10);
// WriteLine(String.Join(",", array));
// int[] res2 = GetArrayRes(array);

// WriteLine(String.Join(" ", res2));


// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }

// int[] GetArrayRes(int[] inArray)
// {

//     int k = inArray.Length / 2;

//     if (inArray.Length % 2 == 1) k++;
//     int[] result1 = new int[k];

//     for (int j = 0; j < inArray.Length / 2; j++)
//     {
//         result1[j] = inArray[j] * inArray[inArray.Length - j - 1];

//     }
//     if (inArray.Length % 2 == 1) result1[k - 1] = inArray[inArray.Length / 2];

//     return result1;
// }

// task 33_DZ Массив, заполненный случайными положит. трехзначными числами
// Напишите программу, кот. покажет число четных чисел
// Clear();
// int[] array = GetArray(6, 100, 1000);
// WriteLine(String.Join(",", array));
// int res = GetHonest(array);

// WriteLine($"Количество чётных элементов {res}");


// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max);
//     }
//     return result;
// }

// int GetHonest(int[] inArray)
// {
//     int count = 0;
//     foreach (int item in inArray)
//     {

//         if (item % 2 == 0)
//         {
//             count = count + 1;
//         }

//     }
//     return count;
// }

// task 36_DZ Одномерный случайный массив. Найти сумму эл-тов,
// стоящих на нечетных позициях

// Clear();
// int[] array = GetArray(10, -99, 100);
// WriteLine(String.Join(",", array));
// int res = SumElementNotEvenPoz(array);

// WriteLine($"Сумма элементов на нечётных позициях {res}");


// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max);
//     }
//     return result;
// }

// int SumElementNotEvenPoz(int[] inArray)
// {
//     int sum = 0;
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         if (i % 2 == 1)
//         {
//             sum = sum + inArray[i];
//         }
//     }
//     return sum;
// }

// task 38_DZ Найти разницу между максимальным
// и минимальным элементом массива.
Clear();
int[] array = GetArray(10, 0, 20);
WriteLine(String.Join(",", array));
int res = DiffMaxMin(array);

WriteLine($"Разница между макс и мин {res}");


int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

int DiffMaxMin(int[] inArray)
{
    int max = inArray[0];
    int min = inArray[0];
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] > max)
        {
            max = inArray[i];
        }
        if (inArray[i] < min)
        {
            min = inArray[i];
        }
    }
    int diff = max - min;
    return diff;
}