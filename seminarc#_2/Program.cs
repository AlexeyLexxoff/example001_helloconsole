// ВЫдача дня недели по заданному числу некдели.

Console.Write("Ener number : ");
string WeekDay = Console.ReadLine();
//int WeekDay = int.Parse(strNum); 

if (WeekDay == "1")
{
    Console.WriteLine("Понедельинк");
}
else if (WeekDay == "2")
{
    Console.WriteLine("Вторник");
}
else if (WeekDay == "3")
{
    Console.WriteLine("Среда");
}
else if (WeekDay == "4")
{
    Console.WriteLine("Четверг");
}
else if (WeekDay == "5")
{
    Console.WriteLine("Пятница");
}
else if (WeekDay == "6")
{
    Console.WriteLine("Суббота");
}
else if (WeekDay == "7")
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("НЕ правильная дата");
}

