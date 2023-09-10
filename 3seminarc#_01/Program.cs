//метод введения id
 
int GetNumber(string message)
{
    System.Console.WriteLine($"Enterr number {message} : ");
int num = Convert.ToInt32(System.Console.ReadLine());
return num;    
}

void Show(int x, int y)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("1 четверть");
    }
    else if (x < 0 && y > 0)
    {
        System.Console.WriteLine("2 четврть ");
    }
    else if (x < 0 && y < 0)
    {
        System.Console.WriteLine("3 четврть ");
    }
    else if (x > 0 && y > 0)
    {
        System.Console.WriteLine("4 четврть ");
    }
    else if (x == 0 || y == 0)
    {
        System.Console.WriteLine("x =/ 0 и y =/ 0");
    }
}

int numX = GetNumber("x");
int numY = GetNumber("y");

Show(numX, numY);

