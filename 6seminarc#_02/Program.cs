// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.


System.Console.WriteLine("Введите три числа");

int SetNumber(string message = "")
{
    Console.WriteLine($"{message}");
    string numberA = System.Console.ReadLine();
    int number = int.Parse(numberA);
    return number;
}

int num1 = SetNumber("Число 1 : ");
int num2 = SetNumber("Число 2 : ");
int num3 = SetNumber("Число 3 : ");

if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
{
    System.Console.WriteLine("Такой треугольник  сущствует");
    
}
else
{
System.Console.WriteLine("Такой треугольник не существует");
}
