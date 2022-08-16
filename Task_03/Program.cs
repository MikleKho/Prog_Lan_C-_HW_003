// Задача 3: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N. 
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}


void Cube_numbers(int Last_number)
{
    System.Console.Write("Кубы чисел от 1 до введенного включительно:  ");
    for (int i = 1; i <= Last_number; i++)
    {
        System.Console.Write($"{Math.Pow(i, 3)}  ");
    }
}

int value_01 = Prompt("Введите число -> ");
Cube_numbers(value_01);