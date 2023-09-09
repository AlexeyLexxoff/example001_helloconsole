System.Console.WriteLine("введите первое число: ");
string number1 = System.Console.ReadLine();
int num1 = int.Parse(number1);
System.Console.WriteLine("введите второе число ");
string number2 = System.Console.ReadLine();
int num2 = int.Parse(number2);

if (num1 * num1 == num2 || num2 * num2 == num1)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}