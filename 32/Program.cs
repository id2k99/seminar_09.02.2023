// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int[] array = GetArray(12, -9, 9);

int[] negativearray = Inv(array);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++ )
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int[] Inv(int[] array)
{
    int[] invarr = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
    {
            invarr[i] = array[i] *(-1);
    }
    return invarr;
}
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", negativearray));

