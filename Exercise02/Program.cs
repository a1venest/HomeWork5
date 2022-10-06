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

int SumNumber(int[] arr)
{
    int sum = 0;
    for(int i =0 ;i< arr.Length;i++)
    {
        if(arr[i]%2>0)
        sum+=arr[i];
    }
    return sum;
}

int[] array = new int[20];
FillArray(array, 1,9);
PrintArray(array);

Console.WriteLine("Сумма нечетных чисел равна: " + SumNumber(array));