// Показать последнюю цифру трехзначного числа

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() !);
if(number / 1000 > 0 || number / 100 == 0)
{
    Console.Write("Введенное число не трахзначное");
}
else Console.WriteLine(number % 10);
