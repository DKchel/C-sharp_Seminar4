// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for (int i = 0; i <= num; i++)
// {
//     sum = sum + i;
// }

// Console.WriteLine(sum);

// С помощью функции:

int GetSumNum()
{
    int sum = 0;
    
    for (int count = 1; count <= num; count++)
    {
        sum = sum + count;
    }

    return sum;
}

int result = GetSumNum();
Console.WriteLine(result);

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSumNum()
// {
// int sum=0;

// int count = 1;
// while(num>=count)
// {
// sum=sum + count;
// count++;
// }
// return sum;
// }
// int result= GetSumNum();
// Console.WriteLine(result);
