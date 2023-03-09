//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//​
//m = 3, n = 4.
//​
//0,5 7 -2 -0,2
//​
//1 -3,3 8 -9,9
//​
//8 7,8 -7,1 9
//​
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

Console.WriteLine("input number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of colums");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
void twoDarray(double[,] matr)
{
    for (int i =0; i<matr.GetLength(0); i++)
    {
        for(int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble();
            Console.Write(matr[i, j]);
        }
        Console.WriteLine();
    }
}
twoDarray(array);
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//​
//Например, задан массив:
//​
//1 4 7 2
//​
//5 9 2 3
//​
//8 4 2 4
//​
//1 7->такого числа в массиве нет
//​

Console.WriteLine("input number of rows");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of colums");
int b = Convert.ToInt32(Console.ReadLine());
int[,] secondarray= new int[a, b];
int[,] createArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar[i, j] = new Random().Next(1, 100);
        }
    }
    return ar;
}
int[,] ints = createArray(secondarray);
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
void FindElement(int a, int b, int[,] array)
{
    Console.WriteLine(array[a, b]);
}
FindElement(x, y, ints);

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] thirdarray = new int[4, 4];
int[,] CreateNewArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            ar[i, j] = new Random().Next(1, 100);
        }
    }
    return ar;
}
double FindingAverage(int[,] matrix)
{

    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            break;
        }
    }
    return sum / matrix.GetLength(0);

}
int[,] ints1 = CreateNewArray(thirdarray);
double result = FindingAverage(ints1);
void PrintMatrix(int[,] matrix)
{
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for(int j =0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(ints1);
Console.WriteLine($"Result is {result}");