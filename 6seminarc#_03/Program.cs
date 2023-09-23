// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    {
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(min, max + 1);
        }
    }
    return array;
}
int[] array = FillArray(8, 1, 10);


int[] CopyArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = array[i] * 2;

    }
    return array2;
}
int[] array2 = CopyArray(array);
System.Console.WriteLine(string.Join(", ", array2));
System.Console.WriteLine(string.Join(" ,", array));

