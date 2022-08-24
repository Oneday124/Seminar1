// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
if(x == y * y)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("false");
}

// Квадрат числа

Console.WriteLine("Введите число: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Квадрат числа: " + Math.Pow(b, 2));

