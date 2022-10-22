// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Enter the number: ");
int divider = int.Parse(Console.ReadLine() !);
int dividend = new Random().Next(0, 1000);
Console.WriteLine($"Dividend: {dividend}");
if(dividend % divider == 0)
{
    Console.WriteLine("The number is a multiple");
}
else
{
    Console.WriteLine($"Number is not multiple. Remainder of the division: {dividend % divider}");
}
