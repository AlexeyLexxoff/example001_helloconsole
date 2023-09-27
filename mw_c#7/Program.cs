// using System;

// public class Answer
// {
//     public static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
//     {
//         double[,] matrix = new double[m, n];        
//         Random random = new Random();
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 matrix[i, j] = random.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom;
//             }
//         }
//         return matrix;



//     }

//     public static void PrintArray(double[,] mattrix)
//     {
//         int m = mattrix.GetLength(0);
//         int n = mattrix.GetLength(1);

//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }

//     }

//     // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int m, n, minLimitRandom, maxLimitRandom;

//         if (args.Length >= 4)
//         {
//             m = int.Parse(args[0]);
//             n = int.Parse(args[1]);
//             minLimitRandom = int.Parse(args[2]);
//             maxLimitRandom = int.Parse(args[3]);

//             double[,] mattrix = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

//             // Выберем случайные индексы трех элементов матрицы mattrix
//             int row1 = new Random().Next(0, m);
//             int col1 = new Random().Next(0, n);
//             int row2 = new Random().Next(0, m);
//             int col2 = new Random().Next(0, n);
//             int row3 = new Random().Next(0, m);
//             int col3 = new Random().Next(0, n);

//             // Проверяем, являются ли выбранные элементы дробными числами
//             bool isFractional1 = (mattrix[row1, col1] % 1) != 0;
//             bool isFractional2 = (mattrix[row2, col2] % 1) != 0;
//             bool isFractional3 = (mattrix[row3, col3] % 1) != 0;

//             // Если два из трех элементов не являются дробными числами, то бросаем исключение
//             if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
//             {
//                 Console.WriteLine("Все ок!");
//             }
//             else
//             {
//                 throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
//             }
//         }
//         else
//         {
//             m = 3;
//             n = 4;
//             minLimitRandom = -10;
//             maxLimitRandom = 10;

//             double[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
//             PrintArray(result);
//         }
//     }
// }



using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }


    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n, m];
        int currentNumber = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = currentNumber;
                currentNumber += k;
            }
        }

        return matrix;

    }

    static void PrintListAvr(double[] list)
    {
        Console.Write("The averages in columns are: ");
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write($"\t{list[i]:F2}");
        }
        Console.WriteLine();


    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        double[] averages = new double[m];

        for (int j = 0; j < m; j++)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, j];
            }
            averages[j] = sum / n;
        }

        return averages;

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 5;
            k = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}