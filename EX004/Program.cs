// Показать числа от -N до N

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() !);
int current = N * (-1);
for(int i = N*(-1); i <= N; i++)
{
    Console.Write($"{i} ");
}