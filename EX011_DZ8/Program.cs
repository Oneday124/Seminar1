// Удалить вторую цифру случайного трёхзначного числа
int Random ()
{
    int number = new Random().Next(99,1000);
    return number;
}
void DelSecondNun (int number)
{
    if(number / 1000 > 0 || number / 100 == 0)
    {
        Console.WriteLine("Введенное число не является трехзначным");
    }
    else
    {
        int first = number / 100;
        int second = number % 100 / 10;
        int third = number % 10;
        Console.Write($"{first}{third}");
    }
    }

int number = Random();
System.Console.WriteLine($"Случайное число: {number}");
DelSecondNun(number);
