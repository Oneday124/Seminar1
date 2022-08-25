// Выяснить является ли число чётным

Console.WriteLine("Enter the number: ");
int number = int.Parse(Console.ReadLine());
if(number % 2 == 0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("odd number");
}