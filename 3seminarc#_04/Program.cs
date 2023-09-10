// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.


System.Console.WriteLine("Введите число: ");
string number = System.Console.ReadLine();
int num1 = int.Parse(number);

int num2 = 1;
while (num2 <= num1)
{
    System.Console.WriteLine(num2 * num2);
    num2++;
}
