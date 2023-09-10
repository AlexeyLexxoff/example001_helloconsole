int GetNumber(string message)
{
    System.Console.WriteLine($"Введите координату {message} : ");
    int num = Convert.ToInt32(System.Console.ReadLine());
    return num;
}
int numX1 = GetNumber("X1");
int numY1 = GetNumber("Y1");
int numX2 = GetNumber("X2");
int numY2 = GetNumber("Y2");

double numX = Math.Pow((numX2 - numX1), 2); // возведение в степеень
double numY = Math.Pow((numY2 - numY1), 2); //

double result = Math.Sqrt(numX + numY); //корень

System.Console.WriteLine($"Результат равен {Math.Round(result, 2)}");