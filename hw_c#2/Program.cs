/// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/// 645 -> 5
/// 78 -> третьей цифры нет
/// 32679 -> 6

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int lngth = num1.ToString().Length;

if (lngth >= 3) 
{
	while (num1 > 999)
	{
		num1 = num1 / 10;
	}
	int result = num1 % 10;
	Console.WriteLine("третье число это  " + result);
} else {
	Console.WriteLine($"{num1} -> Число не имеет третью цифру");
}


_____________________________________________________________________________________________

///Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Ввдите номер дня недели: ");
string Day = Console.ReadLine();
int num1 = int.Parse(Day);

if (Day == "1")
{
    Console.WriteLine("Понедельинк");
}
if (Day == "2")
{
    Console.WriteLine("Вторник");
}
if (Day == "3")
{
    Console.WriteLine("Среда");
}
if (Day == "4")
{
    Console.WriteLine("Четверг");
}
if (Day == "5")
{
    Console.WriteLine("Пятиница");
}
if (Day == "6")
{
    Console.WriteLine("Суббота! Выходной!");
}
if (Day == "7")
{
    Console.WriteLine("Воскерсенье! Выходной!");
}
if(num1 > 7)
{
    System.Console.WriteLine("Введите номер дня недели");
}