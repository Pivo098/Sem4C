// Задача 1: Напишите программу, которая принимает
//  на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ImputInt(string prompt)
{
    System.Console.WriteLine($"{prompt}");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidatePositive(int value)
{
    if (value <= 0)
    {
        System.Console.WriteLine("Введите положительное число");
        return false;
    }
    return true;
}

int SumNumbers(int value)
{
    int sum = 0;
    for(int i = 1; i <= value; i++)
    {
        sum += i;
    }
    return sum;
}
int SumGaussNambers(int value)
{
    return  (1 + value) * value / 2;
}

int value = ImputInt("Введите число");
if (ValidatePositive(value))
{
    int sum = SumNumbers(value);
    System.Console.WriteLine($"Сумма чисел от 1 до {value} равна {sum}");
    System.Console.WriteLine($"Сумма чисел по Гаусу от 1 до {value} равна {SumGaussNambers(value)}");
}