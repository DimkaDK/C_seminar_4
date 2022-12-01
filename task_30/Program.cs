Console.Clear();

int[] RandomArray()
{
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i < array.Length - 1) Console.Write(", ");
    } 
}

int[] result = RandomArray();

PrintArray(result);



