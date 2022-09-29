bool analyzeAnother = true;
string input;

Console.WriteLine("Hello, please tell me your name.");

string userName = Console.ReadLine();


while (analyzeAnother == true)
{
    Console.WriteLine($"{userName}, Please enter a number between 1 and 100 (inclusive)");
    int numberSubmitted = int.Parse(Console.ReadLine());

    if (numberSubmitted >= 1 && numberSubmitted <= 100)
    {
        if (numberSubmitted % 2 > 0)
        {

            if (numberSubmitted < 60)
            {
                Console.WriteLine($"{numberSubmitted} is odd and less than 60");
            }
            else
            {
                Console.WriteLine($"{numberSubmitted} is odd and greater than 60");
            }
        }
        else
        {
            if (numberSubmitted <= 24)
            {
                Console.WriteLine($"{numberSubmitted} is even and less than 25");
            }
            else if (numberSubmitted <= 60)
            {
                Console.WriteLine($"{numberSubmitted} is even and between 26 and 60 inclusive");
            }
            else
            {
                Console.WriteLine($"{numberSubmitted} is even and greater than 60");
            }
        }
    }
    else
    {
        Console.WriteLine($"Sorry {userName} that is not a valid number. Please enter a number between 1 and 100");
    }

    Console.WriteLine($"{userName}, would you like to analyze another number? (Y/N)");

    input = Console.ReadLine();

    if (input.ToLower() == "y")
    {
        analyzeAnother = true;
    }
    else
    {
        analyzeAnother = false;
    }
}
