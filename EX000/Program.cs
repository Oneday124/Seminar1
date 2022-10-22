// Напишите программу, которая на вход принимает число и выдает его квадрат

Console.Write("Веедите число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine($"Квадрат числа {userNumber} = {userNumber * userNumber}");