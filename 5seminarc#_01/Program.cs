// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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
    return;
}


int SumPos(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum += arr[i];
        }

    }
    return sum;
}

int SumNeg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sum += arr[i];
        }

    }
    return sum;
}

int[] arrey = GetArrey(12, -9, 9);
Print(arrey);
int sumP = SumPos(arrey);
int sumN = SumNeg(arrey);

System.Console.WriteLine($"\n{sumP} {sumN}"); 