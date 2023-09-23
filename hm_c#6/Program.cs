// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Колличество элментов  больше нуля : {count}");

// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x +
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

System.Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(System.Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 *  x + b2;
Console.WriteLine($"точка пересечения двух прямых =  X: {x}, Y: {y}");
