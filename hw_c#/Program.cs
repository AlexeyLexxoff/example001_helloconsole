int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());


int max = 0;
int min = 0;

if(numA > numB)
{
    max = numA;
    min = numB;
}
else
{
    max = numB;
    min = numA;
}
Console.WriteLine("max = " + max +  "min = " + min);
_______________________________________________________________________________________________



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine())

Console.Write("Напишите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(numA > max)
{
    max = numA;
}
if(numB > max)
{
    max = numB;
}
if(numC > max)
{
    max = numC;
}
Console.WriteLine("max = " + max);
_______________________________________________________________________________________________


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int remDiv = num % 2;
if(remDiv == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

_______________________________________________________________________________________________


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int evenNum = 2;
if(num > 1)
{
    while(evenNum <= num)
    {
        Console.Write(evenNum + " ");
        evenNum = evenNum + 2;
    }
}
