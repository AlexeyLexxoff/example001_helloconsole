//программа кратности двух  вводных чисел если не кратно выводит остаток деления.


Console.WriteLine("введите первое число: ");
string number1 = Console.ReadLine();
int num1 = int.Parse(number1);

Console.WriteLine("введите второе число: ");
string number2 = Console.ReadLine();
int num2 = int.Parse(number2);

int num = num1 % num2;
if (num == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine($"не кратно, остаток {num}");
}
