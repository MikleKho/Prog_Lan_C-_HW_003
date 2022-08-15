// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int Digit_in_whole_number(int number, int position) // Возвращаем цифру в числе по номеру . Номера справа налево с 1.
{
    int i = 1;
    while (position > i)
    {
        number = number / 10;
        i++;
    }
    return (number % 10);
}

int value_01 = Prompt("Введите положительное пятизначное число (от 10000 до 99999) -> ");
if ((value_01 >= 10000) & (value_01 <= 99999))
{
    if (Digit_in_whole_number(value_01, 1) == Digit_in_whole_number(value_01, 5) &
        Digit_in_whole_number(value_01, 2) == Digit_in_whole_number(value_01, 4))
    {
        System.Console.WriteLine("Полиндром");
    }
    else
    {
        System.Console.WriteLine("Не полиндром");
    }
}
else
{
    System.Console.WriteLine("Input error");
}