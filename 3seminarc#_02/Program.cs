int GetNumber(string message)
{
    System.Console.WriteLine($"Enterr number : ");
    int quart = Convert.ToInt32(System.Console.ReadLine());
    return quart;
}

void Show(int quart)
{
    if (quart == 1)
    {
        System.Console.WriteLine("x > 0, y > 0");
    }
    else if (quart == 2)
    {
        System.Console.WriteLine("x < 0, y > 0 ");
    }
    else if (quart == 3)
    {
        System.Console.WriteLine("x < 0, y < 0  ");
    }
    else if (quart == 4)
    {
        System.Console.WriteLine("x > 0, y < 0  ");
    }
    else
    {
        System.Console.WriteLine("ВВод не корректный");
    }
}
int quart = GetNumber("");
Show(quart);

