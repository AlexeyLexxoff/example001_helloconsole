// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = (result * numA);
    }
    return result;
}

int exp = Exponentiation(numA, numB);
System.Console.WriteLine("Сумма: " + exp);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine("сумма: " + sum);


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] Arrey = new int[8];
Console.Write("");
for (int i = 0; i < Arrey.Length; i++)
{
    Arrey[i] = new Random().Next(0, 9);
    Console.Write(Arrey[i]);
}
