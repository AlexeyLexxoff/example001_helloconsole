﻿// Задача 26: Напишите программу, которая
// принимает на вход число и выдаёт количество цифр
// в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



int GetNumber(string message)
{
    System.Console.WriteLine($"введите число {message}");
    int num = Convert.ToInt32(System.Console.ReadLine());
    return num;
}

int GetCount(int num)
{
    int count = 0;
    for (; 0 < num; num /= 10)
    {
        count = count + 1;
    }
    return count;
}
int num = GetNumber("A");
int resoult = GetCount(num);
System.Console.WriteLine($"количество знаков  = {resoult}");

