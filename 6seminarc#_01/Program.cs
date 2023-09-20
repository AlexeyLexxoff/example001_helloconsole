// //Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int GetNumber(string message)
{
    System.Console.WriteLine($"введите число от {message}");
    int num = Convert.ToInt32(System.Console.ReadLine());
    return num;

}

int[] GetArrey(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);

    }
    return array;
}

void Revert(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }

}
int[] array = GetArrey(5, 1, 50);
System.Console.WriteLine(string.Join (" ", array));
Revert(array);
System.Console.WriteLine(string.Join (" ", array));