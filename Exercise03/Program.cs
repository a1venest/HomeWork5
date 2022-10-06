void FillArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double SubNumber(int[] arr)
{
    

    double MinNumber(int[] arr)
    {
        double min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }

    double MaxNumber(int[] arr)
    {
        double max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    double sub = MaxNumber(arr) - MinNumber(arr);
    return sub;
}

int[] array = new int[20];
FillArray(array, -100, 99);
PrintArray(array);

Console.WriteLine("Разница между максимальным и минимальным элементом равна: " + (SubNumber(array)));
