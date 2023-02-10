// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет

Console.Clear();
Console.WriteLine("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] array = GetArrayFromString(elements);
Console.WriteLine("Введите число для сравнения: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(String.Join(" ", array));

if(FindElement(array, num))
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}



int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElement(int[] array, int e1)
{

foreach (var item in array)
{
    if (e1 == item) return true;
}
return false;

}

