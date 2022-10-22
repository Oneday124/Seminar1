// Напишите программу, которая на вход принимает цифру, обозначающею день недели и проверяет является ли этот день выходным
void DayOff (int number)
{
    if (number > 7)
    {
        System.Console.WriteLine($"{number} isn't week day");
    }
    else if (number == 7 || number == 6)
    {
        System.Console.WriteLine($"{number} is day off ");
    }
    else System.Console.WriteLine($"{number} isn't day off ");
}

System.Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine() !);
DayOff(day);