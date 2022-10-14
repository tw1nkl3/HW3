string num = Console.ReadLine();

if (num.Length == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Неверный ввод");
}