// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

int GetNumByNum()
{
    int mult = 1;
    
    for (int count = 1; count <= num2; count++)
    {
        mult = mult * num1;
    }

    return mult;
}

Console.WriteLine(GetNumByNum());