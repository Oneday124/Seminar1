// Найти третью цифру числа или сообщить, что её нет

int number = new Random().Next(1, 100);
Console.WriteLine("Number: " + number);
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
Console.WriteLine(number % 10);
}



