// // using System;

// // public class Answer
// // {
// //     static bool IsPalindrome(int number)
// //     {
// //         if (number >= 10000 && number <= 99999)
// //         {
// //             int originalNumber = number;
// //             int reversedNumber = 0;

// //             while (number != 0)
// //             {
// //                 int digit = number % 10;
// //                 reversedNumber = reversedNumber * 10 + digit;
// //                 number = number / 10;
// //             }

// //             return originalNumber == reversedNumber;
// //         }
// //         else
// //         {
// //             Console.WriteLine("Number is not five-digit");
// //             return false;
// //         }
// //     }

// //     static void Main(string[] args)
// //     {
// //         int number;

// //         if (args.Length >= 1)
// //         {
// //             number = int.Parse(args[0]);
// //         }
// //         else
// //         {
// //             number = 234322;
// //         }

// //         bool result = IsPalindrome(number);
// //         Console.WriteLine(result);
// //     }
// // }



// public class Answer
// {
//     static void ShowCube(int N)
//     {
//         for (int i = 1; i <= N; i++)
//         {
//             int cube = i * i * i;
//             Console.WriteLine(cube);
//         }
//     }

//     static void Main(string[] args)
//     {
//         int N;

//         if (args.Length >= 1)
//         {
//             N = int.Parse(args[0]);
//         }
//         else
//         {
//             N = 6;
//         }

//         ShowCube(N);
//     }
// }


csharp
using System;

public class Answer
{
    static double DistanceBetweenPoints(int[] pointA, int[] pointB)
    {
        if (pointA.Length != 3 || pointB.Length != 3)
        {
            throw new ArgumentException("Invalid number of coordinates. Expected 3 coordinates for each point.");
        }

        int x1 = pointA[0];
        int y1 = pointA[1];
        int z1 = pointA[2];

        int x2 = pointB[0];
        int y2 = pointB[1];
        int z2 = pointB[2];

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        return distance;
    }

    static void Main(string[] args)
    {
        int[] pointA = { 1, 2, 3 };
        int[] pointB = { 4, 5, 6 };

        double distance = DistanceBetweenPoints(pointA, pointB);
        Console.WriteLine(distance);
    }
}    