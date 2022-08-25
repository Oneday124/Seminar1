// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int outcome = number % 100 / 10;

Console.Write(outcome);

