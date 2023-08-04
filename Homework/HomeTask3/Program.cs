// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите минимум случайных числел массива:");
int arrayMin = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимум случайных числел массива:");
int arrayMax = Convert.ToInt32(Console.ReadLine());

int[] array = new int[8];

void GetArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(arrayMin, arrayMax);
        Console.Write(array[i] + " ");
    }
}

GetArray();