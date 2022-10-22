// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() !);
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
