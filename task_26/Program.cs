Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);

    int number = int.Parse(Console.ReadLine());

    return number;
}

int CountDigital(int number)
{
    int i = 0;

    for (i = 0; number != 0; i++)
    {
        number = number / 10;
    }
    return i;
}

int number = DataEntry("Введите ваше число: ");

int result = CountDigital(number);

Console.Write("Колличество цифр в числе " + number + " равно " + result);