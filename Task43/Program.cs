// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1;
// y = k2 * x + b2;
// x = (b2 - b1) / (k1 - k2);
// y = k1 * x + b1;

using System;
using static System.Console;
Clear();

Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());
Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());
WriteLine();
WriteLine($"Координаты точки пересечения двух прямых: {FindCross(b1, k1, b2, k2)}");
WriteLine();

string FindCross(double b1, double k1, double b2, double k2)
{
    string result = "";
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    result = $"({x}, {y})";
    return result;
}
