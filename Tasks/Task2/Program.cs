﻿// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int GetSumNum()
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }

    return count;
}

int result = GetSumNum();
Console.WriteLine(result);