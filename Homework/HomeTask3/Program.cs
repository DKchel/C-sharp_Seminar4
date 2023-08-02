// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

void GetArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);  // тут не понял ДЗ, поставил рандом до 99, можно также array[i] = new Random().Next(); для рандома без ограничений
        Console.Write(array[i] + " ");
    }
}

GetArray();