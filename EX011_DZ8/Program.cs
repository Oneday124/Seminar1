// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int first = number / 100;
int second = number % 100 / 10;
int third = number % 10;

Console.Write(first);
Console.Write(third);
