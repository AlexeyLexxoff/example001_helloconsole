Console.WriteLine("ВВедите число: ");
string number1 = Console.ReadLine();
int num1 = int.Parse(number1);
if (num1 % 7 == 0 && num1 % 23 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
