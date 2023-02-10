//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();

int[] array = GetArray(12, -9, 9);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++ )
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int SumPositive(int[] arr)

{
    int sumpos =0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumpos += arr[i];
        }
    }

    return sumpos;
}

int SumNegative(int[] arr)

{
    int sumneg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sumneg += arr[i];
        }
    }

    return sumneg;
}

Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Сумма положительных элементов массива: {SumPositive(array)}");
Console.WriteLine($"Сумма положительных элементов массива: {SumNegative(array)}");

