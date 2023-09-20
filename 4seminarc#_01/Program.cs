// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetNumber(string message)
{
    System.Console.WriteLine($"введите число {message}");
    int num = Convert.ToInt32(System.Console.ReadLine());
    return num;
}

int GetSum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum +=i;
    }
    return sum;
}
int numA = GetNumber("A");
int sum = GetSum(numA);
System.Console.WriteLine($"sum = {sum}");

int num = 10;
int num2 = num++;// num2 = 10; num = 10 + 1 = 11.
System.Console.WriteLine($"num = {num} ; num2 = {num2}");

int num3 = ++num;// num = 11 + 1 = 12; num3 = num = 12
System.Console.WriteLine($"num = {num} ; num3 = {num3}");
