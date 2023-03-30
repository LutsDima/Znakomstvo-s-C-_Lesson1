void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int numb = 0;
    
    while(numb < count)
    {
        Console.WriteLine(coll[numb]);
        numb++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int position = -1;
    int index = 0;

    while(index < count)
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

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 50);
Console.WriteLine(pos);
