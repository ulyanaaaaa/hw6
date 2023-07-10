int [] InputSomeNums()
{
    Console.Write("Enter count of numbers: ");
    int size = int.Parse(Console.ReadLine()!);
    int [] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter {i + 1} number: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        Console.Write(", ");
        else Console.Write(". ");
    }
}

int CountPluses(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count; 
}


int[] array = InputSomeNums();
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Count of positives numbers = {CountPluses(array)}");
