// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int Numbers(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int NaturNumb(int n, int m)
{
    if (n == m) return n;
    else
        System.Console.Write($"{NaturNumb(n, m + 1)},");
    return m;
}

int n = Numbers("Введите число: ");
if (n < 1)
{
    return;
}

System.Console.WriteLine(NaturNumb(n, 1));


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


System.Console.WriteLine("введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumNumbers(m, n);

void SumNumbers(int m, int n)
{
    Console.Write(SumNum(m - 1, n));
}

int SumNum(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + (SumNum(m, n));
        return result;
    }


}



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

FunctionAkk(m, n);
void FunctionAkk(int m, int n)
{
    Console.WriteLine(Akkerman(m, n));
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}