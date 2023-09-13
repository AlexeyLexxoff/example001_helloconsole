// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number)
//     {
//         if (number >= 10000 && number <= 99999)
//         {
//             int originalNumber = number;
//             int reversedNumber = 0;

//             while (number != 0)
//             {
//                 int digit = number % 10;
//                 reversedNumber = reversedNumber * 10 + digit;
//                 number = number / 10;
//             }

//             return originalNumber == reversedNumber;
//         }
//         else
//         {
//             Console.WriteLine("Number is not five-digit");
//             return false;
//         }
//     }

//     static void Main(string[] args)
//     {
//         int number;

//         if (args.Length >= 1)
//         {
//             number = int.Parse(args[0]);
//         }
//         else
//         {
//             number = 234322;
//         }

//         bool result = IsPalindrome(number);
//         Console.WriteLine(result);
//     }
// }