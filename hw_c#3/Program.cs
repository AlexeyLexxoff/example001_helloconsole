using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        while (number > 0)
        {
            digits.Add(number % 10);
            number /= 10;
        }

        return digits;// Введите свое решение ниже


    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}