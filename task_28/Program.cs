Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);

    int number = int.Parse(Console.ReadLine());

    return number;
}

int FindSum(int number)
{
    int sum = 1;

    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
    }
    return sum;
}

int number = DataEntry("Введите ваше число: ");

int result = FindSum(number);

Console.WriteLine("Произведение всех чисел до N равна " + result);
