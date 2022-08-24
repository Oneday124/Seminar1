// Показать числа от -N до N

Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int numberB = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;

if(numberA <= numberB)
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

while(min -1 < max)
{
    Console.WriteLine(min);
    min++;
}