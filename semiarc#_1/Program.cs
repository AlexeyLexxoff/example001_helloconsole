///проверка   первого числа квадрата второго


Console.Write("Ener number : ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Ener number : ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

int sqr = num2 * num2;

if (sqr == num1)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}