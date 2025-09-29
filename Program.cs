string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0;
string message = "";
foreach (string value in values)
{
    if (decimal.TryParse(value, out decimal number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.Write($"Message: {message}\nTotal: {total}\r");