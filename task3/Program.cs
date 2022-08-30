// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите 8 элементов: ");
int[] arr = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.Write($"{i+1}: ");
    int temp = Convert.ToInt32(Console.ReadLine());
    arr[i] = temp;
}

void showArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

showArray(arr);