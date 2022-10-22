// Найти третью цифру числа или сообщить, что её нет
int Random()
{
    int number = new Random().Next(1, 10000);
    return number;
}
void ThirdDigitNumber(int number)
{
    if(number < 100)
    {
        Console.WriteLine("There is not third");
    }
    else
    {
        while(number > 1000)
        {
            number = number / 10;
        }
    Console.WriteLine($"The third digit of the number = {number % 10}");
    }
}
int number = Random();
System.Console.WriteLine($"Random number is {number}");
ThirdDigitNumber(number);

