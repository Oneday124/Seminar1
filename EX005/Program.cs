// Показать последнюю цифру трехзначного числа
int GetLastDigit (int number)
{
    return number % 10;
}
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() !);
Console.WriteLine($"Last digit of {number} = {GetLastDigit(number)}");
