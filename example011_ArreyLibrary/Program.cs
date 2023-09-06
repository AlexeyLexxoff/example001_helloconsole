void FillArrey(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArrey(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] arrey = new int[10];
FillArrey(arrey);
arrey[4] = 4;
arrey[6] = 4;
PrintArrey(arrey);
Console.WriteLine();

int pos = Indexof(arrey, 444);
Console.WriteLine(pos);
