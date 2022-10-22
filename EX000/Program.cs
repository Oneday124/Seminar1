// Напишите программу, которая на вход принимает число и выдает его квадрат

Console.Write("Веедите число: ");
int userNumber = int.Parse(Console.ReadLine() ??"0");
int square = userNumber * userNumber;
System.Console.WriteLine($"Квадрат числа {userNumber} = {square}");