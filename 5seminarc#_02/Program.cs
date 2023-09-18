// //Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

void Change(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }

}

int[] array = GetArrey(12, -9, 9);

Print(array);
Change(array);
Print(array);