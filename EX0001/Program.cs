// Напишите программу, которая на вход принимает два числа и проверяет является ли второе число квадратом первого

Console.Write("Введите число 1: ");
int firstUserNumber = int.Parse(Console.ReadLine() !);
Console.Write("Введите число 2: ");
int secondUserNumber = int.Parse(Console.ReadLine() !);
if (secondUserNumber == firstUserNumber * firstUserNumber)
{
    Console.WriteLine($"{secondUserNumber} является квадратом числа {firstUserNumber}");
}
else 
{
    Console.WriteLine($"{secondUserNumber} не является квадратом числа {firstUserNumber}");
}

