// Показать вторую цифру трёхзначного числа
int ReturnThirdNumber(int number)
{
    if(number / 1000 > 0 || number / 100 == 0)
    {
        while(number / 1000 > 0)
        {
            number = number / 10;
        }
        return number % 100 / 10;
    }
    else
    {
        return number % 100 / 10;
    }
}

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() !);
Console.WriteLine($"{ReturnThirdNumber(number)}");

