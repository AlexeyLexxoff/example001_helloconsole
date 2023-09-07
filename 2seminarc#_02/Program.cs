//Рандомное 3х значное число и удаление вторпой цифры этого числа.

int num = new Random().Next(100, 999);
Console.WriteLine(num);

int num1 = num / 100;
int num2 = num % 10;

int rez = num1 * 10 + num2;

System.Console.WriteLine(rez);