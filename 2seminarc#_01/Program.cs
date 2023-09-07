int num = new Random().Next(10, 100);
int num1 = num / 10;
int num2 = num % 10;
Console.WriteLine(num);
if (num1 > num2)
{
    Console.WriteLine($"max = {num1}");
}
else
{
    Console.WriteLine("max = " + num2);
}




//рандомное число и покажет максимальное второе
//int num = new Random(). Next(10, 99);
//Console.WriteLine(num);
//int result = num;
//int twoDigitNumber = Convert.ToInt32(num);
//string stringNumber = Convert.ToString(twoDigitNumber);
//Console.WriteLine("Вторая цифра это :"+stringNumber[1]);


//введите цифрпу и покажит вторую
//Console.WriteLine("ВВедите двухзначное число: ");
//int twoDigitNumber = Convert.ToInt32(Console.ReadLine());
//string stringNumber = Convert.ToString(twoDigitNumber);
//Console.WriteLine("Вторая цифра это :"+stringNumber[1]);

