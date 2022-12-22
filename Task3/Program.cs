//Программа принимает на вход цифру (от 1 до 7 включительно) являющуюся днем недели и проверят является ли этот день выходным

int UserInput()
{
    int number;
    while (true)
    {
        Console.Write("Введите цифру, обозначающую день недели (диапазон от одного до 7): ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return number;
}

int userInput1 = UserInput();

if (userInput1 == 6) Console.WriteLine("Введеная цифра соответствует субботе.");
else if (userInput1 == 7) Console.WriteLine("Введеная цифра соответствует воскресенью.");
else Console.WriteLine("Введенная цифра не соответствует выходному дню.");
