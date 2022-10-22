// Найти максимальное из трех чисел

Console.WriteLine("Введите первое число: ");
int first_number = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("Введите второе число: ");
int second_number = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("Введите третье число: ");
int third_number = int.Parse(Console.ReadLine() ??"0");
int max = 0;

if (first_number > second_number)
{
    max = first_number;
}
else
{
    max = second_number;
}
if (max < third_number)
{
    max = third_number;
}

Console.WriteLine($"Максимальное число: {max}");