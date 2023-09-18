// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]




int[] GetArrey(int size, int min, int max)
{
    int[] arrey = new int[size];
    Random rand = new Random();
    for (int index = 0; index < size; index++)
    {
        arrey[index] = rand.Next(min, max + 1);
    }
    return arrey;
}

void Print(int[]arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.Write($" {arr[i]} ");
    }
}
Print(GetArrey(8, 1, 9));