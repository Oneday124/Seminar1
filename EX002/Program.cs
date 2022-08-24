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

//Вариант 2

int numberA = new Random().Next(1, 10);
Console.WriteLine("Число 1: " + numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine("Число 2: " + numberB);

int max = 0;
int min = 0;
if(numberA < numberB)
{
    max = numberB;
    min = numberA;
}
else
{
    max = numberA;
    min = numberB;
}

Console.WriteLine("min = " + min);
Console.WriteLine("max = " + max);
