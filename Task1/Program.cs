//Программа принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

int UserInput()
{
    int number;
    while (true)
    {
        Console.Write("Введите трехзначное целое число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return number;
}

int userInput1 = UserInput();

int des = (userInput1 - userInput1 / 100 * 100) / 10;

Console.WriteLine($"{userInput1} -> {des}");
