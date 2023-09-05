//программа принеманнт одно число на выходе все целые числа в промежутке

Console.Write("Ener number : ");
string strNum = Console.ReadLine();
int Num = int.Parse(strNum);
int Num0 = Num * -1;

while (Num0 <= Num)
{
    Console.WriteLine(Num0);
    Num0 ++;
}