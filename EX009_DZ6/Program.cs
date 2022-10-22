// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() !);
if(number / 1000 > 0 || number / 100 == 0)
{
    Console.WriteLine("Введенное число не является трехзначным");
}
else
{
    int outcome = number % 100 / 10;
    Console.Write(outcome);
}

