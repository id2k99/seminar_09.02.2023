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

int positiveSum = 0;
int negativeSum = 0;

foreach (var e1 in array)
{
    positiveSum += e1 > 0 ? e1 : 0;
    negativeSum += e1 < 0 ? e1 : 0;      
}

Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Сумма положительных элементов массива: {positiveSum}");
Console.WriteLine($"Сумма положительных элементов массива: {negativeSum}");
