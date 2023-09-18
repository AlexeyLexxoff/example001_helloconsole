System.Console.WriteLine("введите трехзначно число: ");
string number1 = System.Console.ReadLine();
int num = int.Parse(number1);
if (num < 100 || num > 999)
{
    System.Console.WriteLine($"число неврно {num}");
}
else
{
    // int num1 = num % 10;
    // num = num - num1;
    int num2 = (num % 100) / 10;
    System.Console.WriteLine($"Вторая цифра: {num2}");
}