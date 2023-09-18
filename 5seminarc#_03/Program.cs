// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int GetNumber(string message)
{
    System.Console.WriteLine($"введите число {message}");
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

int GetIndexSearch(int[] array, int num)
{
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] == num) 
        {
            return index;
        }
    }
    return -1;    
}

int[] arr = GetArrey(8, -9, 9);

Print(arr);

int gnumb = GetNumber(" ");
int gnumbind = GetIndexSearch(arr, gnumb);

if (gnumbind == -1)
{
    System.Console.WriteLine($"число {gnumb} не найдено");
}
else
System.Console.WriteLine($"индекс  числа {gnumb}  равен {gnumbind}");
