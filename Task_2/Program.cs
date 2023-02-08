Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int SumNum(int num)
{
    if (num < 0)
    {
        num *= -1;
    }
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine($"Сумма всех цифр в числе {num} равна = {SumNum(num)}");