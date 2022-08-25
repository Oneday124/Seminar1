// Найти третью цифру числа или сообщить, что её нет

int number = new Random().Next(1, 10000000);
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



