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

int CountNumber(int[] arr)
{
    int count = 0;
    for(int i =0 ;i< arr.Length;i++)
    {
        if(arr[i]%2==0)
        count++;
    }
    return count;
}

int[] array = new int[100];
FillArray(array, 100, 999);
PrintArray(array);
Console.WriteLine("Колличество четных чисел равно: " + CountNumber(array));
