// Напишите программу, которая
// принимает на вход число N и выдаёт // ФАКТОРИАЛ!
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetNumber(string message)
{
    System.Console.WriteLine($"введите число {message}");
    int num = Convert.ToInt32(System.Console.ReadLine());
    return num;
}

int Composit(int num)
{
    int comp = 1;
    for (int i = 1; i <= num; i++)
    {
        comp = comp * i;
    }
    return comp;
}

int num = GetNumber("");

System.Console.WriteLine($"Факториал числа {num} равен {Composit(num)}");