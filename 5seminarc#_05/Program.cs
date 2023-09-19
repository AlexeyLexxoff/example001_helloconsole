// Задача 35: Задайте одномерный массив из 5 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10, до 99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int GetNumber(string message)
{
    System.Console.WriteLine($"введите число от {message}");
    int num = Convert.ToInt32(System.Console.ReadLine());
    return num;

}

int[] GetArrey(int size, int min, int max)
{
    int[] arrey = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        arrey[i] = rand.Next(min, max + 1);

    }
    return arrey;
}

void Print(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($" {arr[i]} ");
    }
    System.Console.WriteLine();
}

int GetCount(int[] arr, int minN, int maxN)
{
    int countN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= minN && arr[i] <= maxN)
        {
            countN++;
        }
    }
    return countN;
}

int[] arr = GetArrey(5, 0, 123);
Print(arr);

int number1 = GetNumber(" - нижнаяя граница :");
int number2 = GetNumber(" - верхняя граница :");


System.Console.WriteLine($"\t Количество элементов в диапазоне [{number1}, {number2}] равно {GetCount(arr, number1, number2)}");


