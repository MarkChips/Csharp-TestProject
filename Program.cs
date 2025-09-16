// Code project 1 - write code that validates integer input

string? readResult;
bool validEntry = false;
int? result = null;

Console.WriteLine("Enter an integer value between 5 and 10:");
do
{
    readResult = Console.ReadLine();
    if (int.TryParse(readResult, out int userNumber))
    {
        if (userNumber > 5 && userNumber < 10)
        {
            result = userNumber;
            validEntry = true;
        }
        else
        {
            Console.WriteLine($"You entered {userNumber}. Please enter a number between 5 and 10:");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again:");
    }
} while (!validEntry);

Console.WriteLine($"Your input value ({result}) has been accepted.");