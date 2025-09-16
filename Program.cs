/* // Code project 1 - write code that validates integer input

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

Console.WriteLine($"Your input value ({result}) has been accepted."); */

// Code project 2 - write code that validates string input

bool validEntry = false;
string? result = null;

Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
do
{
    string[] roles = { "administrator", "manager", "user" };
    string? userInput = Console.ReadLine(), testCase;

    if (userInput != null)
    {
        testCase = userInput.Trim().ToLower();
        foreach (string role in roles)
            if (testCase == role)
            {
                result = userInput.Trim();
                validEntry = true;
                break;
            }
        if (validEntry) continue;
    }

    Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User):");
} while (!validEntry);

Console.WriteLine($"Your input value ({result}) has been accepted.");