// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int Random ()
{
    int number = new Random().Next(10, 100);
    return number;
}
int BigDigit (int number)
{
    int first_number = number / 10;
    int second_number = number % 10;
        if(first_number > second_number)
        {
            return first_number;
        }
        else
        {
            return second_number;
        } 
}

int number = Random();
Console.WriteLine($"Число: {number}");
Console.WriteLine($"Наибольшая цифра числа = {BigDigit(number)}");