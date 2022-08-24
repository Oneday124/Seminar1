// Даны 2 числа показать большее и меньшее

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int y = Convert.ToInt32(Console.ReadLine());
if(x < y)
{
    Console.WriteLine("Меньшее число: " + x);
    Console.WriteLine("Большее число: " + y);
}
else
{
    Console.WriteLine("Меньшее число: " + y);
    Console.WriteLine("Большее число " + x);
}