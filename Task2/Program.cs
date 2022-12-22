//Программа выводит третью цифру слева у заданного числа или сообщает, что третьей цифры нет

int UserInput()
{
    int number;
    while (true)
    {
        Console.Write("Введите целое положительное число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return number;
}

int userInput1 = UserInput();
int div = 100;
int tmp = 1;

if (userInput1 > 99)
{
    while (tmp > 0)
        {
            tmp = userInput1 / div;
            if (tmp == 0) break;
            div = div * 10;
        }

    int result = userInput1 % (div / 100) / (div / 1000);

    Console.WriteLine($"{userInput1} -> {result}");
}
else Console.WriteLine($"{userInput1} -> третьей цифры нет.");

