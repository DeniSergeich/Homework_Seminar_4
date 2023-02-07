Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int NumPow (int num1, int num2){
    int numPow = num1;
    for (int i = 1; i < num2; i++){
        numPow *= num1;
    }
    return numPow;
}
Console.WriteLine($"Возведение числа {num1} в степень {num2} равно: {NumPow(num1,num2)}");